using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakingAction : MonoBehaviour
{
    PlayerManager playerManager;

    [SerializeField] Slider timerSlider;
    [SerializeField] Text hourText;
    bool isAnim = false;
    int hour = 0;
    float minutes = 0;
    float fillTime;

    void Start()
    {

    }

    void Update()
    {
        if (isAnim)
        {
            timerSlider.value = Mathf.Lerp(timerSlider.minValue, timerSlider.maxValue, fillTime);
            fillTime += 0.5f * Time.deltaTime;


            if (timerSlider.value == timerSlider.maxValue)
            {
                OpenClosePanel();
            }
        }
    }




    public void OpenClosePanel()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        if (!this.gameObject.activeSelf)
        {
            gameObject.SetActive(true);
            minutes = playerManager.player.time.minutes;
            hour = playerManager.player.time.hours;
            isAnim = true;
        }
        else
        {
            gameObject.SetActive(false);
            isAnim = false;
            fillTime = 0;
            timerSlider.value = 0;
        }
    }


}
