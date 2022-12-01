using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code responisble for going sleep
public class GoSleepPanel : MonoBehaviour
{
    PlayerManager playerManager;
    MakingAction makingAction;
    PanelsManager panelsManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    [SerializeField] GameObject actionPanel, actionAnimation;
    int sleepHour;

    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        panelsManager = GameObject.Find("GameManager").GetComponent<PanelsManager>();
        makingAction = actionAnimation.GetComponent<MakingAction>();
    }


    void Update()
    {
        if (gameObject.activeSelf)
        {
            CheckHours();
        }
    }
    //Used by the button, skips time to what player set. Give additional bonuses when the sleeping time is longer than 7(may be changed later during gametesting) 
    public void GoSleep()
    {
        if (playerManager.player.time.hours > 14 || (playerManager.player.time.hours < 6))
        {
            if ((Mathf.Abs(sleepHour - playerManager.player.time.hours)) >= 7)
            {
                playerManager.player.energy = 100;
                playerManager.player.wellbeing += 20;
            }
            else
            {
                var tempEnegry = playerManager.player.energy;
                playerManager.player.energy = 30 + ((sleepHour - playerManager.player.time.hours) * 10);
                if (tempEnegry > playerManager.player.energy)
                {
                    playerManager.player.energy = tempEnegry;
                    playerManager.player.wellbeing += 10;
                }
            }
            //makingAction.OpenClosePanel(1);
            playerManager.player.SetGameHours(sleepHour, true);

            sleepHour = 0;
            playerManager.player.energyDrinkUsage = 0;
            playerManager.player.coffeeUsage = 0;
            playerManager.player.hunger -= 20;
            panelsManager.OpenSleepPanel();

        }
    }


    //Checks what hour is checked and displays it on the panel 
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
