using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerInventory
{
    public Player(string _name)
    {
        _name = name;
        date.days = 1;
        date.seasons = Seasons.Spring;
        date.week = Week.Monday;
        date.years = 2020;
        time.hours = 0;
        time.minutes = 0;
        money = 350;
        job = Job.None;
        recruitTime = -1;
    }

    public Player()
    {
        name = "null";
        date.days = 1;
        date.seasons = Seasons.Spring;
        date.week = Week.Monday;
        date.years = 2020;
        time.hours = 0;
        time.hours = 0;
        time.minutes = 0;
        money = 350;
        recruitTime = -1;
        job = Job.None;
    }






}




