using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversityPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] PanelsManager panelsManager;
    [SerializeField] MakingAction makingAction;
    [SerializeField] GameObject tick1, tick2, tick3, examToday, daysToExamGameObject;
    [SerializeField] Text daysToExam;

    void OnEnable()
    {
        daysToExam.text = (30 - playerManager.player.date.days).ToString();
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
        if (playerManager.player.date.days == 30)
        {
            daysToExamGameObject.SetActive(false);
            examToday.SetActive(true);
        }
        else
        {
            daysToExamGameObject.SetActive(true);
            examToday.SetActive(false);
        }
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
