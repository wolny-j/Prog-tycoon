using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for action panel
public class ActionsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    MakingAction makingAction;
    PanelsManager panelsManager;
    [SerializeField] Text jobDesctiption, buttonText;
    [SerializeField] GameObject actionAnimation, watchTutorialPanel, absence1, absence2, absence3, lostJobPanel, jobButton, playConsoleButton;

    //Setup everything each time the panel is set to active
    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        panelsManager = GameObject.Find("GameManager").GetComponent<PanelsManager>();
        makingAction = actionAnimation.GetComponent<MakingAction>();
        SetUpPanel();

    }

    //Set the description of the activity
    void SetDescription(string descriptionInfo, string buttonInfo)
    {
        jobDesctiption.text = descriptionInfo;
        buttonText.text = buttonInfo;
    }

    //Function used by the button 
    public void WatchTutorial()
    {
        panelsManager.OpenTutorialPanel();
        panelsManager.OpenActionsPanel();
    }

    //Functions used by the buttons to make actions
    //TODO MAKE A SEPARATE FUNCTION FOR NORMAL ACTIVIETIES AS BELOW (SUCH AS WORK FUNCTION) 
    public void ReadBook()
    {
        if (playerManager.player.energy >= 10)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel(1);
            playerManager.player.energy -= 10;
            playerManager.player.SetGameMinutes(0);
            playerManager.player.AddGameHours(2);
            playerManager.player.wellbeing += 10;
        }
    }

    public void GoOut()
    {
        if (playerManager.player.energy >= 35 && playerManager.player.money >= 25 && playerManager.player.time.hours >= 19)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel(4);
            playerManager.player.energy -= 35;
            playerManager.player.SetGameMinutes(0);
            playerManager.player.AddGameHours(4);
            playerManager.player.wellbeing += 35;
            playerManager.player.money -= 25;
        }
    }

    public void PlayConsole()
    {
        if (playerManager.player.energy >= 15)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel(3);
            playerManager.player.energy -= 15;
            playerManager.player.SetGameMinutes(0);
            playerManager.player.AddGameHours(3);
            playerManager.player.wellbeing += 15;
        }
    }


    //Function that sets yp everything on the panel
    void SetUpPanel()
    {
        CheckAbsence();
        jobButton.SetActive(true);
        switch (playerManager.player.job)
        {
            case Job.None:
                jobButton.SetActive(false);
                break;
            case Job.McDonald:
                SetDescription("Time: 9h, Reward: 80$/day, Cost: 65 energy, 20 wellbeing", "McDonald");
                break;
            case Job.PartTimeMcDonald:
                SetDescription("Time: 5h, Reward: 35$/day, Cost: 30 energy, 10 wellbeing", " Part time McDonald");
                break;
            case Job.JuniorProgrammer:
                SetDescription("Time: 8h, Reward: 100$/day, Cost: 55 energy, 10 wellbeing", "Junior Programmer");
                break;
            case Job.MidProgrammer:
                SetDescription("Time: 8h, Reward: 150$/day, Cost: 65 energy, 7 wellbeing", "Mid programmer");
                break;
            default:
                Debug.Log("Unknown job error");
                break;
        }
        Debug.Log(playerManager.player.gamingConsole);
        if (!playerManager.player.gamingConsole)
        {
            playConsoleButton.SetActive(false);
        }
        else
        {
            playConsoleButton.SetActive(true);

        }
    }

    //Function used by the button for going to work
    public void Work()
    {
        switch (playerManager.player.job)
        {
            case Job.McDonald:
                MakeWorkAction(10, 80, 20, 65, 9);
                break;
            case Job.PartTimeMcDonald:
                MakeWorkAction(14, 35, 15, 30, 5);
                break;
            case Job.JuniorProgrammer:
                MakeWorkAction(16, 120, 10, 55, 8);
                break;
            case Job.MidProgrammer:
                MakeWorkAction(16, 170, 15, 65, 8);
                break;
            default:
                break;
        }
    }

    //Make a visualisation in panel about player work absence
    void CheckAbsence()
    {
        if (playerManager.player.jobAbsence == 0)
        {
            absence1.SetActive(false);
            absence2.SetActive(false);
            absence3.SetActive(false);
        }
        else if (playerManager.player.jobAbsence == 1)
        {
            absence1.SetActive(true);
            absence2.SetActive(false);
            absence3.SetActive(false);
        }
        else if (playerManager.player.jobAbsence == 2)
        {
            absence1.SetActive(true);
            absence2.SetActive(true);
            absence3.SetActive(false);
        }
        else if (playerManager.player.jobAbsence == 3)
        {
            playerManager.player.job = Job.None;
            playerManager.player.jobAbsence = 0;
            gameObject.SetActive(false);
            lostJobPanel.SetActive(true);
        }
    }

    //Perform work action by given arguments
    void MakeWorkAction(int deadline, float money, float wellbeing, float energy, int time)
    {
        if (playerManager.player.time.hours < deadline)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel(time);
            if (playerManager.player.energy >= energy)
            {
                playerManager.player.wasAtJob = true;
                if (playerManager.player.wellbeing >= 70)
                {
                    playerManager.player.money += money;
                    playerManager.player.energy -= energy - 5;
                    playerManager.player.wellbeing -= wellbeing - 5;
                    playerManager.player.AddGameHours(time);
                }
                else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
                {
                    playerManager.player.money += money;
                    playerManager.player.energy -= energy;
                    playerManager.player.wellbeing -= wellbeing;
                    playerManager.player.AddGameHours(time);
                }
                else if (playerManager.player.wellbeing < 40)
                {
                    playerManager.player.money += money;
                    playerManager.player.energy -= energy + 10;
                    playerManager.player.wellbeing -= wellbeing + 5;
                    playerManager.player.AddGameHours(time);
                }
            }
        }
    }
}
