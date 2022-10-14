using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsManager : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    [SerializeField] GameObject sleepPanel;
    int sleepHour;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            WatchTutorial();
        }
        if (sleepPanel.activeSelf)
        {
            CheckHours();
        }
    }

    public void WatchTutorial()
    {
        if (playerManager.player.energy > 15)
        {
            playerManager.player.skill += 1;
            playerManager.player.energy -= 15;
            playerManager.player.AddGameHours(2);
            playerManager.player.SetGameMinutes(30);
        }
    }

    public void OpenSleepPanel()
    {
        if (sleepPanel.activeSelf)
        {
            sleepPanel.SetActive(false);
        }
        else
        {
            sleepPanel.SetActive(true);
            hourSliderSleep.value = 3;
        }
    }

    public void GoSleep()
    {
        if (playerManager.player.time.hours > 20 || playerManager.player.time.hours < 12)
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
            OpenSleepPanel();
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
