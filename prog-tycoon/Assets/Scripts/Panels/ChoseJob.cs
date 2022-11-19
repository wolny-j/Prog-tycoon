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

    public void ChoseMcDonald()
    {
        playerManager.player.recruitTime = 0;
        playerManager.player.chosenJob = Job.McDonald;
    }

    public void ChoseMcDonaldPartTime()
    {
        playerManager.player.recruitTime = 3;
        playerManager.player.chosenJob = Job.PartTimeMcDonald;
    }
    public void ChoseJuniorProgrammer()
    {
        if (playerManager.player.csharp > 20)
        {
            playerManager.player.chosenJob = Job.JuniorProgrammer;
        }
    }
    public void ChoseMidProgrammer()
    {
        if (playerManager.player.csharp > 45 && playerManager.player.workExperience > 20)
        {
            playerManager.player.chosenJob = Job.MidProgrammer;
        }
    }
}
