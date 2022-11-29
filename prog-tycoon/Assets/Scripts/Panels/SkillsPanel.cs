using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for displaying player's skills information
public class SkillsPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;

    [Header("Basic Skills")]
    [SerializeField]
    Slider cSharpSlider;
    [SerializeField]
    Slider pythonSlider, javaSlider, webDevSlider, javasriptSlider, databasesSlider, digitalGraphicsSlider;

    [Header("University skills")]
    [SerializeField]
    Slider assemblySlider;
    [SerializeField]
    Slider rustSlider, networkingSlider, machineLearningSlider, haskelSlider, cyberSecuritySlider, cSlider, workExperienceSlider, knowdledgeSlider;


    void OnEnable()
    {
        UpdateSkills();
    }

    //Function responsible for updating information of the all player skills called everytime when the skills panel is opened. 
    void UpdateSkills()
    {
        cSharpSlider.value = playerManager.player.csharp;
        pythonSlider.value = playerManager.player.python;
        javaSlider.value = playerManager.player.java;
        webDevSlider.value = playerManager.player.webdev;
        javasriptSlider.value = playerManager.player.javaScript;
        databasesSlider.value = playerManager.player.databases;
        digitalGraphicsSlider.value = playerManager.player.graphics;

        assemblySlider.value = playerManager.player.assembly;
        rustSlider.value = playerManager.player.rust;
        networkingSlider.value = playerManager.player.networking;
        machineLearningSlider.value = playerManager.player.machineLearning;
        haskelSlider.value = playerManager.player.haskel;
        cyberSecuritySlider.value = playerManager.player.cyberSecurity;
        cSlider.value = playerManager.player.c;

        workExperienceSlider.value = playerManager.player.workExperience;
        knowdledgeSlider.value = playerManager.player.knowdledge;
    }

}
