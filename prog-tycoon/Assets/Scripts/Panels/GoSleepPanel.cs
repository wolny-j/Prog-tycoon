using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoSleepPanel : MonoBehaviour
{
    PlayerManager playerManager;
    PanelsManager panelsManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    int sleepHour;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        panelsManager = GameObject.Find("GameManager").GetComponent<PanelsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            CheckHours();
        }
    }
    public void GoSleep()
    {
        if (playerManager.player.time.hours > 20 || (playerManager.player.time.hours < 6))
        {
            if ((Mathf.Abs(sleepHour - playerManager.player.time.hours)) >= 7)
            {
                playerManager.player.energy = 100;
            }
            else
            {
                var tempEnegry = playerManager.player.energy;
                playerManager.player.energy = 30 + ((sleepHour - playerManager.player.time.hours) * 10);
                if (tempEnegry > playerManager.player.energy)
                {
                    playerManager.player.energy = tempEnegry;
                }
            }
            playerManager.player.SetGameHours(sleepHour, true);

            sleepHour = 0;
            panelsManager.OpenSleepPanel();
        }
    }

    void CheckHours()
    {
        switch (hourSliderSleep.value)
        {
            case 0:
                sleepHour = 6;
                break;
            case 1:
                sleepHour = 7;
                break;
            case 2:
                sleepHour = 8;
                break;
            case 3:
                sleepHour = 9;
                break;
            case 4:
                sleepHour = 10;
                break;
            case 5:
                sleepHour = 11;
                break;
            case 6:
                sleepHour = 12;
                break;
        }
        if (sleepHour < 10)
        {
            sleepHourText.text = "0" + sleepHour.ToString() + ":00";
        }
        else
        {
            sleepHourText.text = sleepHour.ToString() + ":00";
        }
    }
}
