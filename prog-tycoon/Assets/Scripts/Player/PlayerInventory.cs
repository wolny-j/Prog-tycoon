using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{

    public int energyDrink { get; set; }
    public int energyDrinkUsage { get; set; }
    public int water { get; set; }


    public PlayerInventory()
    {
        energyDrink = 0;
        energyDrinkUsage = 0;
        water = 0;
    }
}
