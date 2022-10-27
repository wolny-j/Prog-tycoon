using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    PlayerManager playerManager;
    void Start()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuyEnergyDrink()
    {
        if (playerManager.player.money >= 8)
        {
            playerManager.playerInventory.energyDrink++;
            playerManager.player.money -= 8;
        }
    }
    public void BuyWaterBottle()
    {
        if (playerManager.player.money >= 7)
        {
            playerManager.playerInventory.water++;
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
