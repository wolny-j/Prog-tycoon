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
    public Job job { get; set; }
    public int rentCounter { get; set; }
    public float hunger { get; set; }
    public enum Job
    {
        None,
        McDonald,
        PartTimeMcDonald,
        JuniorProgrammer,
        MidProgrammer,
    }

    public Player(string _name)
    {
        _name = name;
        date = System.DateTime.Now.Date;
        time.hours = 0;
        time.minutes = 0;
        money = 0;
        job = Job.None;
    }

    public Player()
    {
        name = "null";
        date = System.DateTime.Now.Date;
        time.hours = 0;
        time.minutes = 0;
        money = 0;
        job = Job.None;
    }

    public struct GameTime
    {
        public int hours { get; set; }
        public int minutes { get; set; }
    }
    public void AddGameHours(int h)
    {
        time.hours += h;
        for (int i = 1; i <= h; i++)
        {
            hunger -= 4;
        }
        if (time.hours >= 24)
        {
            time.hours = 0;
            rentCounter++;
            date = date.AddDays(1);
            CheckRentTime();
        }
    }
    public void SetGameHours(int h, bool isSleep)
    {
        if (isSleep && (time.hours <= 24 && time.hours > 6))
        {
            rentCounter++;
            date = date.AddDays(1);
            CheckRentTime();
        }
        time.hours = h;
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

    void CheckRentTime()
    {
        if (rentCounter == 7)
        {
            money -= 100;
            rentCounter = 0;
        }
    }



}




