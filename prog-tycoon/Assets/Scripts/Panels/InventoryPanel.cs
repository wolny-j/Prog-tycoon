using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for displaying player's inventory and using item from it 
public class InventoryPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Text energyDrink, water;
    [SerializeField] GameObject bottle1, bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12;

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        UpdateItems();
    }

    //Functions used by the buttons in the panel. 
    public void UseEnergyDrink()
    {
        if (playerManager.player.energyDrink > 0)
        {
            playerManager.player.energyDrinkUsage++;
            playerManager.player.energy += 20;
            playerManager.player.wellbeing -= (10 + (playerManager.player.energyDrinkUsage * 5));
            playerManager.player.energyDrink--;
            energyDrink.text = playerManager.player.energyDrink.ToString();
        }
    }
    public void UseWater()
    {
        if (playerManager.player.water > 0)
        {
            playerManager.player.hunger += 5;
            playerManager.player.water--;
            water.text = playerManager.player.water.ToString();
            switch (playerManager.player.water)
            {
                case 0:
                    bottle1.SetActive(false);
                    break;
                case 1:
                    bottle2.SetActive(false);
                    break;
                case 2:
                    bottle3.SetActive(false);
                    break;
                case 3:
                    bottle4.SetActive(false);
                    break;
                case 4:
                    bottle5.SetActive(false);
                    break;
                case 5:
                    bottle6.SetActive(false);
                    break;
                case 6:
                    bottle7.SetActive(false);
                    break;
                case 7:
                    bottle8.SetActive(false);
                    break;
                case 8:
                    bottle9.SetActive(false);
                    break;
                case 9:
                    bottle10.SetActive(false);
                    break;
                case 10:
                    bottle11.SetActive(false);
                    break;
                case 11:
                    bottle12.SetActive(false);
                    break;
            }
        }
    }

    //Update the infomration about number of the all items
    void UpdateItems()
    {
        energyDrink.text = playerManager.player.energyDrink.ToString();
        water.text = playerManager.player.water.ToString();
    }
}
