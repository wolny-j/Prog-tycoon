using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsible for a choosejob panel
public class ChoseJob : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;

    //Functions used by button in the panel, recruit time gives information how long player will have to wait to get the job
    public void ChoseMcDonald()
    {
        playerManager.player.recruitTime = 0;   //Temporary 0 for debuging process
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
