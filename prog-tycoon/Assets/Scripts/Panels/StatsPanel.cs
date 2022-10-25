using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider skillSlider, workExperienceSlider, wellbeingsSlider, tirednessSlider, knowdledge;
    [SerializeField] Text date, time, money;

    int rentCounter;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        playerManager.player.time.hours = 6;
        playerManager.player.energy = 100;
        playerManager.player.wellbeing = 100;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateValues();
    }

    void UpdateValues()
    {
        skillSlider.value = playerManager.player.skill;
        workExperienceSlider.value = playerManager.player.workExperience;
        wellbeingsSlider.value = playerManager.player.wellbeing;
        if (playerManager.player.wellbeing > 100)
        {
            playerManager.player.wellbeing = 100;
        }
        tirednessSlider.value = playerManager.player.energy;
        knowdledge.value = playerManager.player.knowdledge;
        money.text = playerManager.player.money.ToString();
        date.text = playerManager.player.date.ToString("dd/MM/yyyy");
        time.text = playerManager.player.time.hours.ToString() + ":" + playerManager.player.time.minutes.ToString();
        if (playerManager.player.time.minutes == 0)
        {
            time.text = time.text + "0";
        }
    }

    void CountRent()
    {
        
    }
}
