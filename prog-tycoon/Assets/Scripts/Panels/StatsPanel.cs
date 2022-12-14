using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for displaying player's basic stats information
public class StatsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider wellbeingsSlider, tirednessSlider, hungerSlider;
    [SerializeField] Text date, time, money, rentDue, day;
    [SerializeField] GameObject youGotJob, appliedAtUni;

    //Setup everything at the start of the game
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        playerManager.player.time.hours = 6;
        playerManager.player.energy = 100;
        playerManager.player.wellbeing = 100;
        playerManager.player.hunger = 100;
    }

    void Update()
    {
        UpdateValues();
    }

    //Update all values on the main panel
    void UpdateValues()
    {
        wellbeingsSlider.value = playerManager.player.wellbeing;
        hungerSlider.value = playerManager.player.hunger;
        CheckWellbeingBoundries();
        CheckHungerBoundries();
        tirednessSlider.value = playerManager.player.energy;
        money.text = playerManager.player.money.ToString();
        date.text = playerManager.player.GetDate();
        day.text = playerManager.player.date.week.ToString();
        time.text = playerManager.player.time.hours.ToString() + ":" + playerManager.player.time.minutes.ToString();
        if (playerManager.player.time.minutes == 0)
        {
            time.text = time.text + "0";
        }
        rentDue.text = "Rent payment in: " + (7 - playerManager.player.rentCounter).ToString();
        CheckWorkRecrutation();
        CheckUniversityRecrutation();
    }

    //Check if the wellbeing and hubger value is not above 100
    void CheckWellbeingBoundries()
    {
        if (playerManager.player.wellbeing > 100)
        {
            playerManager.player.wellbeing = 100;
        }
        else if (playerManager.player.wellbeing <= 0)
        {
            playerManager.player.wellbeing = 10;
            playerManager.player.money -= 100;
        }
    }

    void CheckHungerBoundries()
    {
        if (playerManager.player.hunger > 100)
        {
            playerManager.player.hunger = 100;
        }
        else if (playerManager.player.hunger <= 0)
        {
            playerManager.player.hunger = 10;
            playerManager.player.money -= 100;
        }
    }

    void CheckWorkRecrutation()
    {
        if (playerManager.player.recruitTime == 0)
        {
            youGotJob.SetActive(true);
            playerManager.player.job = playerManager.player.chosenJob;
            playerManager.player.recruitTime = -1;
        }
    }

    void CheckUniversityRecrutation()
    {
        if (playerManager.player.isApplied)
        {
            playerManager.player.isApplied = false;
            appliedAtUni.SetActive(true);
        }
    }


}
