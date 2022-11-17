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
    float time = 3;

    void Start()
    {

    }

    void Update()
    {
        if (isAnim)
        {
            timerSlider.value = Mathf.Lerp(timerSlider.minValue, timerSlider.maxValue, fillTime);
            fillTime += 0.5f * (0.1f / time) * Time.deltaTime;
            Debug.Log(fillTime);

            if (timerSlider.value == timerSlider.maxValue)
            {
                OpenClosePanel(1);
            }
        }
    }




    public void OpenClosePanel(float _time)
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        time = _time;

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

    public void SpeedUp()
    {
        fillTime += 0.01f;
    }

}
