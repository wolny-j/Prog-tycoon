using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script used when action is performing and the animation bar panel is opening up
public class MakingAction : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Slider timerSlider;
    bool isAnim = false;
    int hour = 0;
    float minutes = 0;
    float fillTime;
    float time = 3;

    [Header("TableItems")]
    [SerializeField] GameObject zeroAnim;
    [SerializeField] GameObject oneAnim;

    //If the bar is opened animate it, the speed depends on the activity time 
    void Update()
    {
        if (isAnim)
        {
            timerSlider.value = Mathf.Lerp(timerSlider.minValue, timerSlider.maxValue, fillTime);
            fillTime += 0.5f * (0.08f / time) * Time.deltaTime;

            if (timerSlider.value == timerSlider.maxValue)
            {
                DisableAllTableItems();
                OpenClosePanel(1);
            }
        }
    }

    //Used by other scripts to open the panel when animation is performing
    public void OpenClosePanel(float _time)
    {
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

    //Used by button to speedup the animation process
    public void SpeedUp()
    {

        if (!zeroAnim.activeSelf)
        {
            StartCoroutine(AnimateCoding(zeroAnim));
        }
        else if (!oneAnim.activeSelf)
        {
            StartCoroutine(AnimateCoding(oneAnim));
        }

        if (time >= 4)
        {
            fillTime += 0.015f + (time / (100 * time * time * time * time));
        }
        else
        {
            fillTime += 0.015f + (time / (100 * time * time));
        }
    }

    void DisableAllTableItems()
    {
        foreach (GameObject item in playerManager.player.tableItems)
        {
            GameObject.Destroy(item);
        }
        for (int i = 0; i < playerManager.player.isSpawnPointTaken.Length; i++)
        {
            playerManager.player.isSpawnPointTaken[i] = false;
        }
    }

    IEnumerator AnimateCoding(GameObject obj)
    {
        yield return new WaitForSeconds(0.5f);
        obj.SetActive(true);
        yield return new WaitForSeconds(2);
        obj.SetActive(false);
    }

}
