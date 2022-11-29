using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniAdmissionPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] PanelsManager panelsManager;
    public void AcceptAdmission()
    {
        playerManager.player.isUniversity = true;
        panelsManager.ClosePanel(this.gameObject);
    }

    public void RejectAdmission()
    {
        playerManager.player.isUniversity = false;
        panelsManager.ClosePanel(this.gameObject);
    }
}
