using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsible for displaying the shop and buying items 
public class ShopPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;


    //Functions used by the buttons to buy items from the shop panel
    public void BuyEnergyDrink()
    {
        if (playerManager.player.money >= 8)
        {
            playerManager.player.energyDrink++;
            playerManager.player.money -= 8;
        }
    }
    public void BuyWaterBottle()
    {
        if (playerManager.player.money >= 7)
        {
            playerManager.player.water++;
            playerManager.player.money -= 7;
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
