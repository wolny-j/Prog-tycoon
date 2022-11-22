using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player final class with constructors, inharitance used to keep the code clean and separate all the object into subcategories
public class Player : PlayerInventory
{
    public Player(string _name, float startingMoney)
    {
        _name = name;
        date.days = 1;
        date.seasons = Seasons.Spring;
        date.week = Week.Monday;
        date.years = 2020;
        time.hours = 0;
        time.minutes = 0;
        money = startingMoney;
        job = Job.None;
        recruitTime = -1;
        isUniversity = false;
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
        isUniversity = false;
    }
}




