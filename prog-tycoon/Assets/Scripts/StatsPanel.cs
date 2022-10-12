using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider skillSlider, workExperienceSlider, wellbeingsSlider, tirednessSlider, knowdledge;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        skillSlider.value = playerManager.player.skill;
        workExperienceSlider.value = playerManager.player.workExperience;
        wellbeingsSlider.value = playerManager.player.wellbeing;
        tirednessSlider.value = playerManager.player.tiredness;
        knowdledge.value = playerManager.player.knowdledge;

    }
}
