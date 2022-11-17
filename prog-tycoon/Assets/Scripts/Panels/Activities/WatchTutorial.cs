using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchTutorial : MonoBehaviour
{
    PlayerManager playerManager;
    MakingAction makingAction;
    PanelsManager panelsManager;
    [SerializeField] GameObject actionAnimation;

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        panelsManager = GameObject.Find("GameManager").GetComponent<PanelsManager>();
        makingAction = actionAnimation.GetComponent<MakingAction>();
    }
    void Start()
    {

    }

    // Update is called once per frame

    public void WatchCSharp()
    {
        playerManager.player.csharp = Watch(playerManager.player.csharp, 2, 10, 25, 2, 30);
    }

    public void WatchJava()
    {
        playerManager.player.java = Watch(playerManager.player.java, 2, 15, 30, 2, 30);
    }

    public void WatchPython()
    {
        playerManager.player.python = Watch(playerManager.player.python, 2, 10, 20, 2, 0);
    }
    public void WatchJavaScript()
    {
        playerManager.player.javaScript = Watch(playerManager.player.javaScript, 2, 10, 25, 3, 0);
    }
    public void WatchWebDev()
    {
        playerManager.player.webdev = Watch(playerManager.player.webdev, 2, 10, 30, 3, 0);
    }

    public void WatchDatabases()
    {
        playerManager.player.databases = Watch(playerManager.player.databases, 2, 10, 20, 2, 0);
    }

    public void WatchGraphics()
    {
        playerManager.player.graphics = Watch(playerManager.player.graphics, 2, 10, 30, 3, 30);
    }

    float Watch(float temp, float skill, float wellbeing, float energy, int hour, int minute)
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
            Debug.Log(hour);
            makingAction.OpenClosePanel(hour);
            panelsManager.OpenTutorialPanel();

        }
        return temp;
    }
}
