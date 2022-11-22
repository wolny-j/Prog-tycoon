using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Subclass with all infromation about ingame time and date with all methods responsible for manipulating ingame time
public class PlayerTime : PlayerStats
{
    public GameTime time;
    public GameCallendar date;

    //Add hours and change day to the next one if pass midnight
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
            CheckRecrutation();
            CheckJob();
            HandleDate();
            CheckRentTime();
        }
    }
    //Set the game time hour to a specific number (mostly used by sleep function)
    public void SetGameHours(int h, bool isSleep)
    {
        if (isSleep && (time.hours <= 24 && time.hours > 6))
        {
            rentCounter++;
            CheckRecrutation();
            CheckJob();
            HandleDate();
            CheckRentTime();
        }
        time.hours = h;
    }
    //Set the game time minute to a specific number (mostly used by sleep function)
    public void SetGameMinutes(int h)
    {
        time.minutes += h;
        if (time.minutes >= 60)
        {
            time.minutes = 0;
            time.hours += 1;
        }
    }

    //Check if player need to payrent in this day
    void CheckRentTime()
    {
        if (rentCounter == 7)
        {
            money -= 100;
            rentCounter = 0;
        }
    }

    //Method used to update the weeks and seasons in the specific situations
    public void HandleDate()
    {
        date.days++;
        if (date.week != Week.Sunday)
        {
            date.week++;
        }
        else
        {
            date.week = Week.Monday;
        }
        if (date.days > 30)
        {
            jobAbsence = 0;
            date.days = 1;
            if (date.seasons != Seasons.Winter)
            {
                date.seasons++;
            }
            else
            {
                date.seasons = Seasons.Spring;
            }
        }
    }

    public string GetDate()
    {
        string ret = date.days + "/" + date.seasons.ToString() + "/" + date.years;
        return ret;
    }

    //Check if player was at the job 
    public void CheckJob()
    {
        if (!(date.week == Week.Saturday || date.week == Week.Sunday) && job != Job.None)
        {
            if (wasAtJob == false)
            {
                jobAbsence++;
            }
        }
        wasAtJob = false;
    }

    //Check if player got recruited to the job
    void CheckRecrutation()
    {
        if (recruitTime != 0 && recruitTime > 0)
        {
            recruitTime--;
        }
    }
}
