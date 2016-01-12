using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class arrayTest : MonoBehaviour {

    public List<node> dialogue_tree;
    public int current_system;
    public blink change_led;

    //this is ugly
    //don't judge me
    void Start()
    {
        //initial current dialogue system
        current_system = 0;

        //declare connections = DialogueSystem's links
        List<int> connections0 = new List<int>(); List<int> connections6 = new List<int>(); List<int> connections12 = new List<int>(); List<int> connections18 = new List<int>();
        List<int> connections1 = new List<int>(); List<int> connections7 = new List<int>(); List<int> connections13 = new List<int>();
        List<int> connections2 = new List<int>(); List<int> connections8 = new List<int>(); List<int> connections14 = new List<int>();
        List<int> connections3 = new List<int>(); List<int> connections9 = new List<int>(); List<int> connections15 = new List<int>();
        List<int> connections4 = new List<int>(); List<int> connections10 = new List<int>(); List<int> connections16 = new List<int>();
        List<int> connections5 = new List<int>(); List<int> connections11 = new List<int>(); List<int> connections17 = new List<int>();
        //add all of the links
        connections0.Add(2); connections0.Add(1); connections0.Add(3);          //Done  
        connections1.Add(4); connections1.Add(8); connections1.Add(1);          //Done
        connections2.Add(3); connections2.Add(3); connections2.Add(1);          //Done
        connections3.Add(22); connections3.Add(16); connections3.Add(3);        //Done
        connections4.Add(5); connections4.Add(6); connections4.Add(7);          //Done
        connections5.Add(10); connections5.Add(10); connections5.Add(10);       //Done
        connections6.Add(12); connections6.Add(13); connections6.Add(13);       //Done
        connections7.Add(5); connections7.Add(9); connections7.Add(9);          //Done
        connections8.Add(11); connections8.Add(11); connections8.Add(11);       //Done
        connections9.Add(11); connections9.Add(11); connections9.Add(11);       //Done
        connections10.Add(13); connections10.Add(14); connections10.Add(13);    //Done
        connections11.Add(10); connections11.Add(15); connections11.Add(10);    //Done
        connections12.Add(17); connections12.Add(18); connections12.Add(16);    //Done
        connections13.Add(18); connections13.Add(19); connections13.Add(17);    //Done
        connections14.Add(20); connections14.Add(9); connections14.Add(21);     //Done 
        connections15.Add(5); connections15.Add(9); connections15.Add(14);      //Done     
        connections16.Add(9); connections16.Add(9); connections16.Add(13);      //Done
        connections17.Add(23); connections17.Add(9); connections17.Add(9);      //Done
        connections18.Add(5); connections18.Add(24); connections18.Add(25);    //Done

  
        //declare true paths = DialogueSystems truths
        List<bool> truth0 = new List<bool>();
        List<bool> truth1 = new List<bool>();
        List<bool> truth2 = new List<bool>();
        List<bool> truth3 = new List<bool>();
        List<bool> truth4 = new List<bool>();
        List<bool> truth5 = new List<bool>();
        List<bool> truth6 = new List<bool>();
        List<bool> truth7 = new List<bool>();
        //add all true/falses           - silences are true
        truth0.Add(true); truth0.Add(true); truth0.Add(true);
        truth1.Add(true); truth1.Add(true); truth1.Add(false);
        truth2.Add(true); truth2.Add(false); truth2.Add(true);  // Circle truths
        truth3.Add(false); truth3.Add(true); truth3.Add(true);  // Did you agree to the deal? Truths
        truth4.Add(false); truth4.Add(false); truth4.Add(true);
        truth5.Add(false); truth5.Add(true); truth5.Add(false);
        truth6.Add(true); truth6.Add(false); truth6.Add(false); //Triangle truths
        truth7.Add(false); truth7.Add(false); truth7.Add(false);

        //create new DialogueSystems for each response/connection
        dialogue_tree = new List<node>();
        string[] textFile = System.IO.File.ReadAllLines(@"Assets\Scripts\test-text.txt");

        //each component in the text file is broken up by ;

        //CHANGED: delimiter to ; because the text contains .'s at times and this is confusing and messes with ordering
        //also, removed all delimiters at the end of each line because with one on the end
        //it adds another spot to words, so the length ends up being 8 instead of 7
        char[] delimiterChars = { ';' };

        //words = list of phrases in the text file: question.responses.truths
        string[] words = null;

        //reads entire file, breaks up phrases, and puts them into a string array

        /*
            Issue: this is another, more code efficient of loading all of the possible dialogue options
            at the beginning of the game. Our goal by the end is to only load options when the player reaches
            them. 
        */

        for (int x = 0; x < textFile.Length; x++)
        {
            //only loads one line into words because it's values are constantly being written over
            words = textFile[x].Split(delimiterChars);
        }

        //type converter
        //moving in increments of 7 across words[]
        for (int y = 0; y < words.Length; y = y + 7)
        {
            //what does this do?
            //bool tp = convertBool(words[y + 4]);

            //create new node in dialogue_tree
            dialogue_tree.Add(new node(words[y], words[y + 1], words[y + 2], words[y + 3], convertBool(words[y + 4]), convertBool(words[y + 5]), convertBool(words[y + 6])));
        }
        
        dialogue_tree[0].links = connections0;

        //because we only have one words, we only have one node in dialogue_tree, so [2 - 25] doesn't exist

        /*dialogue_tree[1].links = connections1;
        dialogue_tree[2].links = connections2;
        dialogue_tree[3].links = connections3;
        dialogue_tree[4].links = connections4;
        dialogue_tree[5].links = connections5;
        dialogue_tree[6].links = connections6;
        dialogue_tree[7].links = connections5;
        dialogue_tree[8].links = connections7;
        dialogue_tree[9].links = connections6;
        dialogue_tree[10].links = connections8;
        dialogue_tree[11].links = connections9;
        dialogue_tree[12].links = connections10;
        dialogue_tree[13].links = connections5;
        dialogue_tree[14].links = connections11;
        dialogue_tree[15].links = connections5;
        dialogue_tree[16].links = connections12;
        dialogue_tree[17].links = connections13;
        dialogue_tree[18].links = connections14;
        dialogue_tree[19].links = connections15;
        dialogue_tree[20].links = connections16;
        dialogue_tree[21].links = connections6;
        dialogue_tree[22].links = connections17;
        dialogue_tree[23].links = connections18;
        dialogue_tree[24].links = connections18;
        dialogue_tree[25].links = connections5;*/
    }

    //gets the list of player responses avaliable at the current system
    public List<string> getDialogueSystem()
    {
        List<string> curr_dialogue = new List<string>(dialogue_tree[current_system].responses);
        return curr_dialogue;
    }

    public bool convertBool(string temp)
    {
        if (temp == "false")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //gets the question presented to the player at the current system
    public string getQuestion()
    {
        return dialogue_tree[current_system].question;
    }

    //determines whether the player's response was correct/true or not
    public void true_or_false(int index)
    {
        //look at the current truth
        //if it's false then call BlinkLoop(true) == LED light starts flashing
        //if the player's response is true, then stop BlinkLoop
        if (!dialogue_tree[current_system].truths[index])
        {
            change_led.change_LED(true);
        }
        else
        {
            change_led.change_LED(false);
        }
    }

    //changes the current system
    public void setCurrentSystem(int selected_button_num)
    {
        current_system = dialogue_tree[current_system].links[selected_button_num];
    }
}
