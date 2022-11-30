using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsible for displaying the shop and buying items 
public class ShopPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [Header("Bottles")]
    [SerializeField] GameObject bottle1;
    [SerializeField] GameObject bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12;

    [Header("Energy Drinks")]
    [SerializeField] GameObject energyDrink1;
    [SerializeField] GameObject energyDrink2, energyDrink3, energyDrink4, energyDrink5, energyDrink6;


    //Functions used by the buttons to buy items from the shop panel
    public void BuyEnergyDrink()
    {
        if (playerManager.player.money >= 8)
        {
            playerManager.player.energyDrink++;
            playerManager.player.money -= 8;
            switch (playerManager.player.energyDrink)
            {
                case 1:
                    energyDrink1.SetActive(true);
                    break;
                case 2:
                    energyDrink2.SetActive(true);
                    break;
                case 3:
                    energyDrink3.SetActive(true);
                    break;
                case 4:
                    energyDrink4.SetActive(true);
                    break;
                case 5:
                    energyDrink5.SetActive(true);
                    break;
                case 6:
                    energyDrink6.SetActive(true);
                    break;
            }
        }
    }
    public void BuyWaterBottle()
    {
        if (playerManager.player.money >= 7)
        {
            playerManager.player.water++;
            playerManager.player.money -= 7;
            switch (playerManager.player.water)
            {
                case 1:
                    bottle1.SetActive(true);
                    break;
                case 2:
                    bottle2.SetActive(true);
                    break;
                case 3:
                    bottle3.SetActive(true);
                    break;
                case 4:
                    bottle4.SetActive(true);
                    break;
                case 5:
                    bottle5.SetActive(true);
                    break;
                case 6:
                    bottle6.SetActive(true);
                    break;
                case 7:
                    bottle7.SetActive(true);
                    break;
                case 8:
                    bottle8.SetActive(true);
                    break;
                case 9:
                    bottle9.SetActive(true);
                    break;
                case 10:
                    bottle10.SetActive(true);
                    break;
                case 11:
                    bottle11.SetActive(true);
                    break;
                case 12:
                    bottle12.SetActive(true);
                    break;
            }
        }
    }
    public void OrderBurger()
    {
        if (playerManager.player.money >= 30)
        {
            playerManager.player.SetGameMinutes(30);
            playerManager.player.hunger += 45;
            playerManager.player.money -= 30;
        }
    }
    public void OrderSandwich()
    {
        if (playerManager.player.money >= 15)
        {
            playerManager.player.SetGameMinutes(15);
            playerManager.player.hunger += 18;
            playerManager.player.money -= 15;
        }
    }
}
