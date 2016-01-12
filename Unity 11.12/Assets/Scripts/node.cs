﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class node
{
    public string question;

    public List<string> responses;

    public List<bool> truths;

    public node parent;

    public int data;

    public List<int> links;

    public node(string ques, string ans1, string ans2, string ans3, bool truth1, bool truth2, bool truth3)
    {
        //Added: the lists need to be constructed for the strings to be added to them
        responses = new List<string>();
        truths = new List<bool>();

        question = ques;
        responses.Add(ans1);
        responses.Add(ans2);
        responses.Add(ans3);
        truths.Add(truth1);
        truths.Add(truth2);
        truths.Add(truth3);
    }

}
