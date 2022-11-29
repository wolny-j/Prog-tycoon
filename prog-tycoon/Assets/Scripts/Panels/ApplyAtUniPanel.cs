using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyAtUniPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    public void ApplyAtUniversity()
    {
        playerManager.player.appliedAtUni = true;
    }
}
