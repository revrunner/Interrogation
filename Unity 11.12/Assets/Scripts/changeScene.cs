using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {
    //move scenes based on scene_name
    public void moveScene(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }

}
