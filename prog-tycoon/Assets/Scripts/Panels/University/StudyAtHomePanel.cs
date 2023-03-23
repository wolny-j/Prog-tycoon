using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsible for studying 
public class StudyAtHomePanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] PanelsManager panelsManager;
    [SerializeField] MakingAction makingAction;

    //All these functions are used by the buttons for studying a certain subject 

    public void StudyAssembly()
    {
        Study(playerManager.player.assembly, 2, 15, 30, 3, 30);
    }
    public void StudyRust()
    {
        Study(playerManager.player.rust, 2, 10, 30, 3, 30);
    }
    public void StudyMachineLearning()
    {
        Study(playerManager.player.machineLearning, 2, 20, 35, 4, 30);
    }
    public void StudyCyberSecurity()
    {
        Study(playerManager.player.cyberSecurity, 2, 15, 30, 3, 0);
    }
    public void StudyNetworking()
    {
        Study(playerManager.player.networking, 2, 10, 30, 3, 0);
    }
    public void StudyHaskel()
    {
        Study(playerManager.player.haskel, 2, 15, 35, 3, 30);
    }
    public void StudyC()
    {
        Study(playerManager.player.c, 2, 15, 35, 4, 0);
    }

    //Perform action by given arguments
    float Study(float temp, float skill, float wellbeing, float energy, int hour, int minute)
    {
        if (playerManager.player.energy >= energy)
        {
            if (playerManager.player.wellbeing >= 70)
            {
                temp += skill;
                playerManager.player.energy -= energy - 10;
                playerManager.player.SetGameMinutes(minute);
                playerManager.player.AddGameHours(hour);
                playerManager.player.wellbeing -= wellbeing - 5;
            }
            else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
            {
                temp += skill;
                playerManager.player.energy -= energy;
                playerManager.player.SetGameMinutes(minute);
                playerManager.player.AddGameHours(hour);
                playerManager.player.wellbeing -= wellbeing;
            }
            else if (playerManager.player.wellbeing < 40)
            {
                temp += 1;
                playerManager.player.energy -= energy + 10;
                playerManager.player.SetGameMinutes(minute + 30);
                playerManager.player.AddGameHours(hour);
                playerManager.player.wellbeing -= wellbeing + 5;
            }
            makingAction.OpenClosePanel(hour);
            panelsManager.OpenStudyAtHomePanel();

        }
        return temp;
    }
}
