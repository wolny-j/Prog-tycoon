using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player player = new Player();
    public PlayerInventory playerInventory = new PlayerInventory();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputTestValues();
    }

    void InputTestValues()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.skill += 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.workExperience += 10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.wellbeing += 10;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            player.energy += 10;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            player.knowdledge += 10;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.AddGameHours(1);
        }
    }
}
