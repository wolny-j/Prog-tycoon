using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider wellbeingsSlider, tirednessSlider, hungerSlider;
    [SerializeField] Text date, time, money, rentDue, day;
    [SerializeField] GameObject youGotJob;

    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        playerManager.player.time.hours = 6;
        playerManager.player.energy = 100;
        playerManager.player.wellbeing = 100;
        playerManager.player.hunger = 100;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateValues();
    }

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
        if (playerManager.player.recruitTime == 0)
        {
            youGotJob.SetActive(true);
            playerManager.player.job = playerManager.player.chosenJob;
            playerManager.player.recruitTime = -1;
        }
    }

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


}
