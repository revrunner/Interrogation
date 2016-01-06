using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueSystem {

    //i.e. Question - How are you?
    // Responses - Fine     Good        Bad
    // choice - Bad
    //      New Question - Why are you bad?
    //  Responses - Not sure    Failed a test   Parakeet Died
    //      etc.    etc.    etc.

    //where the responses link to in our dialoguesystem
    public List<int> links;

    //the player's available repsonses in this system
    public List<string> responses;

    //which player response is correct
    public List<bool> truths;

    //current question
    public string question;

    //public bool r1, r2, r3;

    public DialogueSystem(string ques, List<int> l, List<string> r, List<bool> b)
    {
        question = ques;
        links = new List<int>(l);
        responses = new List<string>(r);
        truths = new List<bool>(b);
    }

}
