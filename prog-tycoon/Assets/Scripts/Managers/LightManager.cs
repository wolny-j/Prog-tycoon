using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField] Light mainLight, lampLight;
    [SerializeField] PlayerManager playerManager;
    

    void Update()
    {
        if (playerManager.player.time.hours > 18 || playerManager.player.time.hours < 6)
        {
            lampLight.intensity = Mathf.Lerp(lampLight.intensity, 4f, 2f * Time.deltaTime);
            mainLight.intensity = Mathf.Lerp(mainLight.intensity, 0.25f, 0.5f * Time.deltaTime);
        }
        else
        {
            lampLight.intensity = Mathf.Lerp(lampLight.intensity, 0f, 2f * Time.deltaTime);
            mainLight.intensity = Mathf.Lerp(mainLight.intensity, 1f, 0.5f * Time.deltaTime);
        }
    }
}
