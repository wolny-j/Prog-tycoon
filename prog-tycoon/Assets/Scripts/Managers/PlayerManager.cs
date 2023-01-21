using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script with a player that is used by other scripts
public class PlayerManager : MonoBehaviour
{
    //Create player object
    public Player player = new Player("Loerm Ipsum", 450f);
    void Update()
    {
        InputTestValues();
    }

    //Just for gametesting DELETE LATER
    void InputTestValues()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            player.csharp += 10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.wellbeing -= 10;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            player.energy += 10;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.AddGameHours(1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.HandleDate();
        }
    }
}
