using UnityEngine;
using System.Collections;
using Uniduino;

public class blink : MonoBehaviour {

    public Arduino arduino;

    public int blink_pin = 13;
    // Use this for initialization
    void Start()
    {

        arduino = Arduino.global;
        arduino.Log = (s) => Debug.Log("Arduino: " + s);

        arduino.Setup(ConfigurePins);

        ConfigurePins();
        //StartCoroutine(BlinkLoop());
    }

    void ConfigurePins()
    {
        Debug.Log("set pin mode");
        arduino.pinMode(blink_pin, PinMode.OUTPUT);
    }

    public void change_LED(bool blink_led)
    {
        //if the LED should blink repeatedly, startcoroutine BlinkLoop(bool = true)
        //otherwise stop coroutine BlinkLoop
        if (blink_led)
        {
            StartCoroutine("BlinkConstant");
        }
        else
        {
            StopCoroutine("BlinkConstant");
            //turns off LED if caught in on position
            arduino.digitalWrite(blink_pin, Arduino.LOW);
        }
        
    }

    //blinks LED light once
    IEnumerator BlinkButtonDelay()
    {
        arduino.digitalWrite(blink_pin, Arduino.HIGH);
        yield return new WaitForSeconds(1);
        arduino.digitalWrite(blink_pin, Arduino.LOW);
    }

    IEnumerator BlinkConstant()
    {
        arduino.digitalWrite(blink_pin, Arduino.HIGH);
        yield return new WaitForSeconds(0);
    }

    //blinks LED light repeatedly
    IEnumerator BlinkLoop(bool go)
    {
        while (go)
        {  
            arduino.digitalWrite(blink_pin, Arduino.HIGH); // led ON			
            yield return new WaitForSeconds(1);
            arduino.digitalWrite(blink_pin, Arduino.LOW); // led OFF
            yield return new WaitForSeconds(1);
        }
    }
}


