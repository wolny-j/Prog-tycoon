using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsPanel : MonoBehaviour
{
    PlayerManager playerManager;
    MakingAction makingAction;
    PanelsManager panelsManager;
    [SerializeField] Text jobDesctiption, buttonText;
    [SerializeField] GameObject actionAnimation, watchTutorialPanel, absence1, absence2, absence3, lostJobPanel;

    void Start()
    {

    }

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        panelsManager = GameObject.Find("GameManager").GetComponent<PanelsManager>();
        makingAction = actionAnimation.GetComponent<MakingAction>();
        SetUpPanel();

    }
    void Update()
    {


    }

    void SetDescription(string descriptionInfo, string buttonInfo)
    {
        jobDesctiption.text = descriptionInfo;
        buttonText.text = buttonInfo;

    }

    public void WatchTutorial()
    {
        panelsManager.OpenTutorialPanel();
        panelsManager.OpenActionsPanel();
    }

    public void ReadBook()
    {
        if (playerManager.player.energy >= 10)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel();
            playerManager.player.energy -= 10;
            playerManager.player.SetGameMinutes(30);
            playerManager.player.AddGameHours(1);
            playerManager.player.wellbeing += 5;
        }
    }

    public void GoOut()
    {
        if (playerManager.player.energy >= 35 && playerManager.player.money >= 25 && playerManager.player.time.hours >= 19)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel();
            playerManager.player.energy -= 35;
            playerManager.player.SetGameMinutes(0);
            playerManager.player.AddGameHours(4);
            playerManager.player.wellbeing += 30;
            playerManager.player.money -= 25;
        }
    }


    void SetUpPanel()
    {
        CheckAbsence();
        if (playerManager.player.job == Player.Job.None)
        {
            SetDescription("", "Unavailable");
        }
        else if (playerManager.player.job == Player.Job.McDonald)
        {
            SetDescription("Time: 9h, Reward: 80$/day, Cost: 65 energy, 20 wellbeing", "McDonald");
        }
        else if (playerManager.player.job == Player.Job.PartTimeMcDonald)
        {
            SetDescription("Time: 5h, Reward: 35$/day, Cost: 30 energy, 10 wellbeing", " Part time McDonald");
        }
        else if (playerManager.player.job == Player.Job.JuniorProgrammer)
        {
            SetDescription("Time: 8h, Reward: 100$/day, Cost: 55 energy, 10 wellbeing", "Junior Programmer");
        }
        else if (playerManager.player.job == Player.Job.MidProgrammer)
        {
            SetDescription("Time: 8h, Reward: 150$/day, Cost: 65 energy, 7 wellbeing", "Mid programmer");
        }
    }

    //TODO CHANGE TO FUNTION SAME AS WATCHING TUTORIALS
    public void Work()
    {
        if (playerManager.player.job == Player.Job.None)
        {

        }
        else if (playerManager.player.job == Player.Job.McDonald)
        {
            if (playerManager.player.time.hours < 10)
            {
                panelsManager.OpenActionsPanel();
                makingAction.OpenClosePanel();
                if (playerManager.player.energy >= 65)
                {
                    playerManager.player.wasAtJob = true;
                    if (playerManager.player.wellbeing >= 70)
                    {
                        playerManager.player.money += 80;
                        playerManager.player.energy -= 60;
                        playerManager.player.wellbeing -= 15;
                        playerManager.player.AddGameHours(9);
                    }
                    else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
                    {
                        playerManager.player.money += 80;
                        playerManager.player.energy -= 65;
                        playerManager.player.wellbeing -= 20;
                        playerManager.player.AddGameHours(9);
                    }
                    else if (playerManager.player.wellbeing < 40)
                    {
                        playerManager.player.money += 80;
                        playerManager.player.energy -= 75;
                        playerManager.player.wellbeing -= 25;
                        playerManager.player.AddGameHours(9);
                    }


                }
            }
        }
        else if (playerManager.player.job == Player.Job.PartTimeMcDonald)
        {
            if (playerManager.player.time.hours < 14)
            {
                panelsManager.OpenActionsPanel();
                makingAction.OpenClosePanel();
                if (playerManager.player.energy >= 30)
                {
                    playerManager.player.wasAtJob = true;
                    if (playerManager.player.wellbeing >= 70)
                    {
                        playerManager.player.money += 35;
                        playerManager.player.energy -= 25;
                        playerManager.player.wellbeing -= 10;
                        playerManager.player.AddGameHours(5);
                    }
                    else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
                    {
                        playerManager.player.money += 35;
                        playerManager.player.energy -= 30;
                        playerManager.player.wellbeing -= 15;
                        playerManager.player.AddGameHours(5);
                    }
                    else if (playerManager.player.wellbeing < 40)
                    {
                        playerManager.player.money += 35;
                        playerManager.player.energy -= 40;
                        playerManager.player.wellbeing -= 20;
                        playerManager.player.AddGameHours(5);
                    }

                }
            }
        }
        else if (playerManager.player.job == Player.Job.JuniorProgrammer)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel();
            if (playerManager.player.energy >= 55)
            {
                playerManager.player.wasAtJob = true;
                if (playerManager.player.wellbeing >= 70)
                {
                    playerManager.player.money += 100;
                    playerManager.player.energy -= 50;
                    playerManager.player.wellbeing -= 10;
                    playerManager.player.AddGameHours(8);
                }
                else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
                {
                    playerManager.player.money += 100;
                    playerManager.player.energy -= 55;
                    playerManager.player.wellbeing -= 10;
                    playerManager.player.AddGameHours(8);
                }
                else if (playerManager.player.wellbeing < 40)
                {
                    playerManager.player.money += 100;
                    playerManager.player.energy -= 65;
                    playerManager.player.wellbeing -= 15;
                    playerManager.player.AddGameHours(8);
                }
            }
        }
        else if (playerManager.player.job == Player.Job.MidProgrammer)
        {
            panelsManager.OpenActionsPanel();
            makingAction.OpenClosePanel();
            if (playerManager.player.energy >= 65)
            {
                playerManager.player.wasAtJob = true;
                if (playerManager.player.wellbeing >= 70)
                {
                    playerManager.player.money += 150;
                    playerManager.player.energy -= 60;
                    playerManager.player.wellbeing -= 7;
                    playerManager.player.AddGameHours(8);
                }
                else if (playerManager.player.wellbeing >= 40 && playerManager.player.wellbeing < 70)
                {
                    playerManager.player.money += 150;
                    playerManager.player.energy -= 60;
                    playerManager.player.wellbeing -= 10;
                    playerManager.player.AddGameHours(8);
                }
                else if (playerManager.player.wellbeing < 40)
                {
                    playerManager.player.money += 150;
                    playerManager.player.energy -= 70;
                    playerManager.player.wellbeing -= 10;
                    playerManager.player.AddGameHours(8);
                }

            }
        }
    }

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
            gameObject.SetActive(false);
            lostJobPanel.SetActive(true);
        }
    }
}
