using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseJob : MonoBehaviour
{
    PlayerManager playerManager;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChoseMcDonald()
    {
        playerManager.player.recruitTime = 5;
        playerManager.player.chosenJob = Player.Job.McDonald;
    }

    public void ChoseMcDonaldPartTime()
    {
        playerManager.player.recruitTime = 3;
        playerManager.player.chosenJob = Player.Job.PartTimeMcDonald;
    }
    public void ChoseJuniorProgrammer()
    {
        if (playerManager.player.csharp > 20)
        {
            playerManager.player.chosenJob = Player.Job.JuniorProgrammer;
        }
    }
    public void ChoseMidProgrammer()
    {
        if (playerManager.player.csharp > 45 && playerManager.player.workExperience > 20)
        {
            playerManager.player.chosenJob = Player.Job.MidProgrammer;
        }
    }
}
