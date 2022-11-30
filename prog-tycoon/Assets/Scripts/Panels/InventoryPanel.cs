using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for displaying player's inventory and using item from it 
public class InventoryPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Text energyDrink, water;
    [SerializeField] GameObject bottleUI, energyDrinkUI;
    [Header("Bottles")]
    [SerializeField] GameObject bottle1;
    [SerializeField] GameObject bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12;
    [Header("Energy Drinks")]
    [SerializeField] GameObject energyDrink1;
    [SerializeField] GameObject energyDrink2, energyDrink3, energyDrink4, energyDrink5, energyDrink6;

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        UpdateItems();

        if (playerManager.player.energyDrink < 1)
        {
            energyDrinkUI.SetActive(false);
        }
        else
        {
            energyDrinkUI.SetActive(true);
        }
        if (playerManager.player.water < 1)
        {
            bottleUI.SetActive(false);
        }
        else
        {
            bottleUI.SetActive(true);
        }
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
            switch (playerManager.player.energyDrink)
            {
                case 0:
                    energyDrink1.SetActive(false);
                    break;
                case 1:
                    energyDrink2.SetActive(false);
                    break;
                case 2:
                    energyDrink3.SetActive(false);
                    break;
                case 3:
                    energyDrink4.SetActive(false);
                    break;
                case 4:
                    energyDrink5.SetActive(false);
                    break;
                case 5:
                    energyDrink6.SetActive(false);
                    break;
            }
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
