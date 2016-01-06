using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChangeButtonText : MonoBehaviour
{
    //clicked button
    public GameObject button;
    //reference to arrayTest script = so we can use their functions
    public arrayTest get_dialogue;

    public void changeText()
    {

        //grab all three buttons on the scene
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");
        GameObject question_box = GameObject.FindGameObjectWithTag("Question");

        //find out which button was selected
        //  1 = top-right
        //  2 = top-left
        //  3 = bottom-middle
        int selected_button_num = 0;
        while(buttons[selected_button_num] != button)
        {
            selected_button_num++;
        }

        //determine if the player response was true/correct
        get_dialogue.true_or_false(selected_button_num);

        //change the current dialogue system
        get_dialogue.setCurrentSystem(selected_button_num);
        

        //get the current dialogue system
        List<string> new_text = get_dialogue.getDialogueSystem();

        question_box.GetComponent<Text>().text = get_dialogue.getQuestion();

        //change the text of each button
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = new_text[i];
        }
    }

   
}
