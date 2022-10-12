using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name { get; set; }
    public float skill { get; set; }
    public float workExperience { get; set; }
    public float wellbeing { get; set; }
    public float tiredness { get; set; }
    public float knowdledge { get; set; }



    public Player(string _name)
    {
        _name = name;
    }

    public Player()
    {
        name = "null";
    }


}




