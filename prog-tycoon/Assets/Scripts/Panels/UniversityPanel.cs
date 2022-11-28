using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversityPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] PanelsManager panelsManager;
    [SerializeField] MakingAction makingAction;
    [SerializeField] GameObject tick1, tick2, tick3;

    void OnEnable()
    {
        switch (playerManager.player.attendance)
        {
            case 0:
                break;
            case 1:
                tick1.SetActive(true);
                break;
            case 2:
                tick2.SetActive(true);
                break;
            case 3:
                tick3.SetActive(true);
                break;
        }
    }
    public void ApplyAtUniversity()
    {
        playerManager.player.appliedAtUni = true;
    }

    public void GoToUiversity()
    {
        if (playerManager.player.energy >= 50 && playerManager.player.attendance < 3)
        {
            panelsManager.OpenUniversityPanel();
            makingAction.OpenClosePanel(5);
            playerManager.player.energy -= 50;
            playerManager.player.SetGameMinutes(30);
            playerManager.player.AddGameHours(5);
            playerManager.player.wellbeing -= 15;
            playerManager.player.knowdledge += 1;
            playerManager.player.attendance++;
            switch (Random.Range(0, 7))
            {
                case 0:
                    playerManager.player.assembly++;
                    break;
                case 1:
                    playerManager.player.rust++;
                    break;
                case 2:
                    playerManager.player.machineLearning++;
                    break;
                case 3:
                    playerManager.player.cyberSecurity++;
                    break;
                case 4:
                    playerManager.player.networking++;
                    break;
                case 5:
                    playerManager.player.haskel++;
                    break;
                case 6:
                    playerManager.player.c++;
                    break;
            }
        }
    }

    public void StudyAtHome()
    {
        panelsManager.OpenUniversityPanel();
        panelsManager.OpenStudyAtHomePanel();
    }


}
