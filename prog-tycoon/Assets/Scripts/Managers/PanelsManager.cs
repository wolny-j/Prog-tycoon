using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsManager : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    [SerializeField] GameObject sleepPanel, actionsPanel, findJobPanel, shopPanel, inventoryPanel, skillsPanel, tutorialPanel;
    int sleepHour;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OpenSleepPanel()
    {
        if (sleepPanel.activeSelf)
        {
            sleepPanel.SetActive(false);
        }
        else
        {
            sleepPanel.SetActive(true);
            hourSliderSleep.value = 3;
        }
    }

    public void OpenActionsPanel()
    {
        if (actionsPanel.activeSelf)
        {
            actionsPanel.SetActive(false);
        }
        else
        {
            actionsPanel.SetActive(true);
        }
    }

    public void OpenTutorialPanel()
    {
        if (tutorialPanel.activeSelf)
        {
            tutorialPanel.SetActive(false);
        }
        else
        {
            tutorialPanel.SetActive(true);
        }
    }

    public void OpenJobFindPanel()
    {
        if (findJobPanel.activeSelf)
        {
            findJobPanel.SetActive(false);
        }
        else
        {
            findJobPanel.SetActive(true);
        }
    }
    public void OpenShopPanel()
    {
        if (shopPanel.activeSelf)
        {
            shopPanel.SetActive(false);
        }
        else
        {
            shopPanel.SetActive(true);
        }
    }
    public void OpenInventoryPanel()
    {
        if (inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(false);
        }
        else
        {
            inventoryPanel.SetActive(true);
        }
    }

    public void OpenSkillsPanel()
    {
        if (skillsPanel.activeSelf)
        {
            skillsPanel.SetActive(false);
        }
        else
        {
            skillsPanel.SetActive(true);
        }
    }
}
