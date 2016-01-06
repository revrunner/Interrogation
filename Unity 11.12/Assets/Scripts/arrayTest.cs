using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class arrayTest : MonoBehaviour {

    public List<DialogueSystem> dialogue_tree;
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

        //declare responses = DialogueSystem's responses
        List<string> responses0 = new List<string>(); List<string> responses6 = new List<string>(); List<string> responses12 = new List<string>(); List<string> responses18 = new List<string>();
        List<string> responses1 = new List<string>(); List<string> responses7 = new List<string>(); List<string> responses13 = new List<string>();
        List<string> responses2 = new List<string>(); List<string> responses8 = new List<string>(); List<string> responses14 = new List<string>();
        List<string> responses3 = new List<string>(); List<string> responses9 = new List<string>(); List<string> responses15 = new List<string>();
        List<string> responses4 = new List<string>(); List<string> responses10 = new List<string>(); List<string> responses16 = new List<string>();
        List<string> responses5 = new List<string>(); List<string> responses11 = new List<string>(); List<string> responses17 = new List<string>();
        //add all of the response options
        responses0.Add("He was trying to make a deal with me."); responses0.Add("He wanted to hire me."); responses0.Add("He confessed that he was going to kill my mother tonight and wanted my help.");
        responses1.Add("Yes, I agreed to the job."); responses1.Add("No, I didn't."); responses1.Add("");
        responses2.Add("He wanted us to kill her so that he could take over the business."); responses2.Add("He wanted me to help him sabotage the company."); responses2.Add("He wanted to hire me.");
        //      Did you agree to the deal? Responses
        responses3.Add("Yes."); responses3.Add("No."); responses3.Add("");
        responses4.Add("The money."); responses4.Add("To prove to my Mother that I'm capable."); responses4.Add("To make her proud.");
        //      Triangle responses  = 5
        responses5.Add("She doesn't like that I'm not as successful as her. She puts pressure on me to make money."); responses5.Add("She thinks nothing of me. It's like she's ignoring my existence."); responses5.Add("She's disappointed in me. She knows about my drug prolem and judges me for it. She won't let me take care of myself.");
        //      Circle Responses = 6
        responses6.Add("Hate."); responses6.Add("Nothing, really."); responses6.Add("Disappointment.");
        responses7.Add("I like what I do."); responses7.Add("I don't want to work for her company. I don't like what they do."); responses7.Add("It would make my Mom too happy. Not into it.");
        //      Feels responses - 8
        responses8.Add("Angry."); responses8.Add("Sad."); responses8.Add("Lonely.");
        responses9.Add("Quit"); responses9.Add("Play Again"); responses9.Add("");
        responses10.Add("She doesn't respect me."); responses10.Add("Her drinking problem."); responses10.Add("She doesn't care about me.");
        responses11.Add("She would abuse me, call me names, sometimes even fight. The more she drank, the worse it got."); responses11.Add("She would argue with anyone around her. Even break things. She drove Dad away with that shit."); responses11.Add("It led me to start drinking and getting into drugs. I can't ignore that it had an impact on me.");
        responses12.Add("We never understnd each other anymore."); responses12.Add("It destroyed our relationship. We've never been the same."); responses12.Add("I've resented her for breaking up our family.");
        responses13.Add("I ignored him. I didn't take him seriously."); responses13.Add("I spoke to my mother about it, thought she'd be able to do something."); responses13.Add("");
        responses14.Add("Poison his drink."); responses14.Add("Nothing."); responses14.Add("Call the cops.");
        responses15.Add("My job."); responses15.Add("How she treats me."); responses15.Add("Her alcoholism.");
        responses16.Add("It was surprising. I was not expecting her to tell me to do that."); responses16.Add("I'm not sure."); responses16.Add("I don't know why she'd think I would be capable of doing that. Or why she'd think I'd agree.");
        responses17.Add("He said he'd pay me."); responses17.Add("I thought it was a good idea."); responses17.Add("She deserved it.");
        responses18.Add("I don't like my mother."); responses18.Add("I can't feel anymore, so I thought, why not?."); responses18.Add("He made a good argument?");

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
        dialogue_tree = new List<DialogueSystem>();
        dialogue_tree.Add(new DialogueSystem("What were the two of you talking about?", connections0, responses0, truth6));
        dialogue_tree.Add(new DialogueSystem("He wanted to hire you? You work as an artist and don't make much from doing that. Did you agree?",  connections1, responses1, truth7));
        dialogue_tree.Add(new DialogueSystem("What was the deal?", connections2, responses2, truth5));
        //      Did you agree to the deal? Dialogue_Tree
        dialogue_tree.Add(new DialogueSystem("Did you agree to the deal?", connections3, responses3, truth3));
        //      Get Hired.
        dialogue_tree.Add(new DialogueSystem("Why did you take the job?", connections4, responses4, truth7));
        dialogue_tree.Add(new DialogueSystem("What does your mother think about your job? Maybe I should be more general about this. What does your mother think of you?", connections5, responses5, truth6));
        dialogue_tree.Add(new DialogueSystem("She must not think much of you. How do you feel about her? Your mother.", connections6, responses6, truth2));
        dialogue_tree.Add(new DialogueSystem("Why would you need to make your mother proud? What does she think of you?", connections5, responses5, truth6));
        //      Don't Get Hired.
        dialogue_tree.Add(new DialogueSystem("Why didn't you take the job?", connections7, responses7, truth6));
        //      CIRCLE - 9
        dialogue_tree.Add(new DialogueSystem("How do you feel about your mother?", connections6, responses6, truth2));
        //      FEELS - 10
        dialogue_tree.Add(new DialogueSystem("How did this make you feel? Or what word would you use to describe how you feel about the relationship you had with your mother?", connections8, responses8, truth0));
        //      END - 11
        dialogue_tree.Add(new DialogueSystem("Thanks for playing!", connections9, responses9, truth0));
        dialogue_tree.Add(new DialogueSystem("Why do you hate her?", connections10, responses10, truth1));
        //      TRIANGLE - 13
        dialogue_tree.Add(new DialogueSystem("What does your mother think of you?", connections5, responses5, truth6));
        dialogue_tree.Add(new DialogueSystem("How did that effect you growing up?", connections11, responses11, truth6));
        dialogue_tree.Add(new DialogueSystem("How did the divorce effect the relationship you had with her?", connections5, responses12, truth6));
        //      No to the deal - 16
        dialogue_tree.Add(new DialogueSystem("So after he told about this, what did you do?", connections12, responses13, truth3));
        dialogue_tree.Add(new DialogueSystem("Is this what you and your mother argued about that night?", connections13, responses3, truth3));
        dialogue_tree.Add(new DialogueSystem("What did she tell you to do about it?", connections14, responses14, truth7));
        dialogue_tree.Add(new DialogueSystem("Then what did you two argue about?", connections15, responses15, truth6));
        dialogue_tree.Add(new DialogueSystem("How did you feel about your mother telling you to do this?", connections16, responses16, truth7));
        dialogue_tree.Add(new DialogueSystem("Well we know that didn't happen since no officers were ever called. So I guess we'll just move on. How do you feel about your mother?", connections6, responses6, truth2));
        //      Yes to the deal - 22
        dialogue_tree.Add(new DialogueSystem("Why did you agree?", connections17, responses17, truth7));
        dialogue_tree.Add(new DialogueSystem("Did you need the money?", connections18, responses3, truth3));
        dialogue_tree.Add(new DialogueSystem("Then why did you agree if you didn't need the money?", connections18, responses18, truth3));
        dialogue_tree.Add(new DialogueSystem("Wow, you can joke about this? Let's move on. What does your mother think of you?", connections5, responses5, truth6));
    }

    //gets the list of player responses avaliable at the current system
    public List<string> getDialogueSystem()
    {
        List<string> curr_dialogue = new List<string>(dialogue_tree[current_system].responses);
        return curr_dialogue;
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
