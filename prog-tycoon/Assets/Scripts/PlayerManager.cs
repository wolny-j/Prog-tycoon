using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player player = new Player();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
            player.tiredness += 10;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            player.knowdledge += 10;
        }
    }
}
