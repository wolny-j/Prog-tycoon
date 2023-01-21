using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SubClass responsible for player inventory
public class PlayerInventory : PlayerSkills
{
    public int energyDrink { get; set; }
    public int energyDrinkUsage { get; set; }
    public int coffeeUsage { get; set; }
    public int water { get; set; }
    public bool[] isSpawnPointTaken = new bool[4];
    public GameObject[] tableItems = new GameObject[4];
    public bool gamingConsole { get; set; }


}
