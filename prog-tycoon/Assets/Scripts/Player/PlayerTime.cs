using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTime : PlayerStats
{
    public GameTime time;
    public GameCallendar date;
    public enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter,
    }
    public enum Week
    {
        Monday,
        Tuesday,
        Wenesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    public struct GameTime
    {
        public int hours { get; set; }
        public int minutes { get; set; }
    }

    public struct GameCallendar
    {
        public int days;
        public Week week;
        public Seasons seasons;
        public int years;
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
            CheckRecrutation();
            CheckJob();
            HandleDate();
            CheckRentTime();
        }
    }
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
    public void SetGameMinutes(int h)
    {
        time.minutes += h;
        if (time.minutes >= 60)
        {
            time.minutes = 0;
            time.hours += 1;
        }
    }

    void CheckRentTime()
    {
        if (rentCounter == 7)
        {
            money -= 100;
            rentCounter = 0;
        }
    }

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

    public void CheckJob()
    {
        if (!(date.week == Player.Week.Saturday || date.week == Player.Week.Sunday) && job != Player.Job.None)
        {
            if (wasAtJob == false)
            {
                jobAbsence++;
            }
        }
        wasAtJob = false;
    }

    void CheckRecrutation()
    {
        if (recruitTime != 0 && recruitTime > 0)
        {
            recruitTime--;
        }
    }
}
