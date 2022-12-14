using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Subclass with all player statistics
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
    public bool appliedAtUni { get; set; }
    public bool isUniversity { get; set; }
    public bool isApplied { get; set; }
    public int attendance { get; set; }
    public int examDue { get; set; }


}
