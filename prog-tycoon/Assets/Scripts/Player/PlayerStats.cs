using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats
{
    public string name { get; set; }
    public float workExperience { get; set; }
    public float wellbeing { get; set; }
    public float energy { get; set; }

    public float money { get; set; }
    public int rentCounter { get; set; }
    public float hunger { get; set; }
    public bool wasAtJob { get; set; }
    public int jobAbsence { get; set; }
    public int recruitTime { get; set; }
    public Job job { get; set; }
    public Job chosenJob { get; set; }
    public enum Job
    {
        None,
        McDonald,
        PartTimeMcDonald,
        JuniorProgrammer,
        MidProgrammer,
    }

}
