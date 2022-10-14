using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name { get; set; }
    public float skill { get; set; }
    public float workExperience { get; set; }
    public float wellbeing { get; set; }
    public float energy { get; set; }
    public float knowdledge { get; set; }
    public System.DateTime date { get; set; }
    public float money { get; set; }
    public struct GameTime
    {
        public int hours { get; set; }
        public int minutes { get; set; }
    }
    public void AddGameHours(int h)
    {
        time.hours += h;
        if (time.hours >= 24)
        {
            time.hours = 0;
            date = date.AddDays(1);
        }
    }
    public void SetGameHours(int h, bool isSleep)
    {
        time.hours = h;
        if (isSleep)
        {
            date = date.AddDays(1);
        }
    }
    public void SetGameMinutes(int h)
    {
        time.minutes += h;
        if (time.minutes >= 60)
        {
            time.minutes = 0;
            time.hours += 1;
        }
    }

    public GameTime time;


    public Player(string _name)
    {
        _name = name;
        date = System.DateTime.Now.Date;
        time.hours = 0;
        time.minutes = 0;
        money = 0;
    }

    public Player()
    {
        name = "null";
        date = System.DateTime.Now.Date;
        time.hours = 0;
        time.minutes = 0;
        money = 0;
    }


}




