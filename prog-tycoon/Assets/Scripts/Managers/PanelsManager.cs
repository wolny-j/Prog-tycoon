using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsManager : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Slider hourSliderSleep;
    [SerializeField] Text sleepHourText;
    [SerializeField] GameObject sleepPanel, actionsPanel, findJobPanel;
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






}
