using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for managing all panels in game
public class PanelsManager : MonoBehaviour
{
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] PlayerManager playerManager;
    [Header("Panels")]
    [SerializeField] GameObject sleepPanel;
    [SerializeField]
    GameObject actionsPanel, findJobPanel, shopPanel, inventoryPanel, skillsPanel, tutorialPanel, allButtons,
     lostJobPanel, gotJobPanel, universityPanel, applyAtUniPanel, studyAtHomePanel;


    //These functions are used by buttons in game to open/close panels  
    public void OpenSleepPanel()
    {
        if (sleepPanel.activeSelf)
        {
            ClosePanel(sleepPanel);
        }
        else
        {
            OpenPanel(sleepPanel);
            //Set a bar in the middle(just for nice design)
            hourSliderSleep.value = 3;
        }
    }

    public void OpenActionsPanel()
    {
        if (actionsPanel.activeSelf)
        {
            ClosePanel(actionsPanel);
        }
        else
        {
            OpenPanel(actionsPanel);
        }
    }

    public void OpenTutorialPanel()
    {
        if (tutorialPanel.activeSelf)
        {
            ClosePanel(tutorialPanel);
        }
        else
        {
            OpenPanel(tutorialPanel);
        }
    }

    public void OpenJobFindPanel()
    {
        if (findJobPanel.activeSelf)
        {
            ClosePanel(findJobPanel);
        }
        else
        {
            OpenPanel(findJobPanel);
        }
    }
    public void OpenShopPanel()
    {
        if (shopPanel.activeSelf)
        {
            ClosePanel(shopPanel);
        }
        else
        {
            OpenPanel(shopPanel);
        }
    }
    public void OpenInventoryPanel()
    {
        if (inventoryPanel.activeSelf)
        {
            ClosePanel(inventoryPanel);
        }
        else
        {
            OpenPanel(inventoryPanel);
        }
    }

    public void OpenSkillsPanel()
    {
        if (skillsPanel.activeSelf)
        {
            ClosePanel(skillsPanel);
        }
        else
        {
            OpenPanel(skillsPanel);
        }
    }

    public void OpenUniversityPanel()
    {
        if (playerManager.player.isUniversity)
        {
            if (universityPanel.activeSelf)
            {
                ClosePanel(universityPanel);
            }
            else
            {
                OpenPanel(universityPanel);
            }
        }
        else
        {
            OpenApplyUniversityPanel();
        }
    }
    public void OpenStudyAtHomePanel()
    {
        if (studyAtHomePanel.activeSelf)
        {
            ClosePanel(studyAtHomePanel);
        }
        else
        {
            OpenPanel(studyAtHomePanel);
        }
    }
    public void OpenApplyUniversityPanel()
    {
        if (applyAtUniPanel.activeSelf)
        {
            ClosePanel(applyAtUniPanel);
        }
        else
        {
            OpenPanel(applyAtUniPanel);
        }
    }
    public void CloseYouLostJobPanel()
    {
        ClosePanel(lostJobPanel);
    }

    public void CloseYouGotJobPanel()
    {
        ClosePanel(gotJobPanel);
    }

    //Functions used by all above for opening and closing panels given in the argument
    void ClosePanel(GameObject panel)
    {
        allButtons.SetActive(true);
        panel.SetActive(false);
    }

    void OpenPanel(GameObject panel)
    {
        allButtons.SetActive(false);
        panel.SetActive(true);
    }
}
