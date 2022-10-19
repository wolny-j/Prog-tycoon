using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Text jobDesctiption, buttonText;
    void Start()
    {

    }

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        if (playerManager.player.job == Player.Job.None)
        {
            jobDesctiption.text = "";
            buttonText.text = "Unavailable";
        }
        else if (playerManager.player.job == Player.Job.McDonald)
        {
            jobDesctiption.text = "Time: 8h, Reward: 80$/day, Cost: 65 energy";
            buttonText.text = "McDonald";
        }
        else if (playerManager.player.job == Player.Job.PartTimeMcDonald)
        {
            jobDesctiption.text = "Time: 4h, Reward: 35$/day, Cost: 30 energy";
            buttonText.text = "Part time McDonald";
        }
    }
    void Update()
    {


    }

    public void WatchTutorial()
    {
        if (playerManager.player.energy >= 15)
        {
            playerManager.player.skill += 1;
            playerManager.player.energy -= 15;
            playerManager.player.AddGameHours(2);
            playerManager.player.SetGameMinutes(30);
        }
    }

    public void Work()
    {
        if (playerManager.player.job == Player.Job.None)
        {

        }
        else if (playerManager.player.job == Player.Job.McDonald)
        {
            if (playerManager.player.energy >= 65)
            {
                playerManager.player.money += 80;
                playerManager.player.energy -= 65;
                playerManager.player.AddGameHours(8);
            }
        }
        else if (playerManager.player.job == Player.Job.PartTimeMcDonald)
        {
            if (playerManager.player.energy >= 35)
            {
                playerManager.player.money += 40;
                playerManager.player.energy -= 35;
                playerManager.player.AddGameHours(4);
            }
        }
    }
}
