using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsManager : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    [SerializeField] GameObject sleepPanel, actionsPanel, findJobPanel, shopPanel, inventoryPanel, skillsPanel, tutorialPanel, allButtons, lostJobPanel, gotJobPanel;
    int sleepHour;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.player.jobAbsence == 3)
        {

        }
    }


    public void OpenSleepPanel()
    {
        if (sleepPanel.activeSelf)
        {
            allButtons.SetActive(true);
            sleepPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            sleepPanel.SetActive(true);
            hourSliderSleep.value = 3;
        }
    }

    public void OpenActionsPanel()
    {
        if (actionsPanel.activeSelf)
        {
            allButtons.SetActive(true);
            actionsPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            actionsPanel.SetActive(true);
        }
    }

    public void OpenTutorialPanel()
    {
        if (tutorialPanel.activeSelf)
        {
            allButtons.SetActive(true);
            tutorialPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            tutorialPanel.SetActive(true);
        }
    }

    public void OpenJobFindPanel()
    {
        if (findJobPanel.activeSelf)
        {
            allButtons.SetActive(true);
            findJobPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            findJobPanel.SetActive(true);
        }
    }
    public void OpenShopPanel()
    {
        if (shopPanel.activeSelf)
        {
            allButtons.SetActive(true);
            shopPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            shopPanel.SetActive(true);
        }
    }
    public void OpenInventoryPanel()
    {
        if (inventoryPanel.activeSelf)
        {
            allButtons.SetActive(true);
            inventoryPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            inventoryPanel.SetActive(true);
        }
    }

    public void OpenSkillsPanel()
    {
        if (skillsPanel.activeSelf)
        {
            allButtons.SetActive(true);
            skillsPanel.SetActive(false);
        }
        else
        {
            allButtons.SetActive(false);
            skillsPanel.SetActive(true);
        }
    }

    public void CloseYouLostJobPanel()
    {
        allButtons.SetActive(true);
        lostJobPanel.SetActive(false);
    }

    public void CloseYouGotJobPanel()
    {
        allButtons.SetActive(true);
        gotJobPanel.SetActive(false);
    }
}
