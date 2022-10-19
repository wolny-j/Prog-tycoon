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
        playerManager.player.job = Player.Job.McDonald;
    }

    public void ChoseMcDonaldPartTime()
    {
        playerManager.player.job = Player.Job.PartTimeMcDonald;
    }
    public void ChoseJuniorProgrammer()
    {
        if (playerManager.player.skill > 20)
        {
            playerManager.player.job = Player.Job.JuniorProgrammer;
        }
    }
    public void ChoseMidProgrammer()
    {
        if (playerManager.player.skill > 45 && playerManager.player.workExperience > 20 && playerManager.player.knowdledge > 10)
        {
            playerManager.player.job = Player.Job.MidProgrammer;
        }
    }
}
