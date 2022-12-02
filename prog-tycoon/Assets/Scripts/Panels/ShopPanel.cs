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

    [SerializeField] GameObject tableCoffeeCup, tableSandwich, spawnpoint1, spawnpoint2, spawnpoint3, spawnpoint4;


    //Functions used by the buttons to buy items from the shop panel
    public void BuyEnergyDrink()
    {
        if (playerManager.player.money >= 8)
        {
            GameObject[] energyDrinks = { energyDrink1, energyDrink2, energyDrink3, energyDrink4, energyDrink5, energyDrink6 };
            playerManager.player.energyDrink++;
            playerManager.player.money -= 8;

            ShowItemInFridge(energyDrinks, playerManager.player.energyDrink);
        }
    }
    public void BuyWaterBottle()
    {
        if (playerManager.player.money >= 7)
        {
            GameObject[] waterBottles = { bottle1, bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12 };
            playerManager.player.water++;
            playerManager.player.money -= 7;
            ShowItemInFridge(waterBottles, playerManager.player.water);

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
            SpawnItemOnTable(tableSandwich, new Vector3(-90, 0, 0));

        }
    }
    public void BuyCoffee()
    {
        if (playerManager.player.money >= 15)
        {
            playerManager.player.coffeeUsage++;
            playerManager.player.energy += 20;
            playerManager.player.wellbeing -= (10 + (playerManager.player.coffeeUsage * 3));
            playerManager.player.money -= 15;
            SpawnItemOnTable(tableCoffeeCup, new Vector3(-90, 180, 144.827f));

        }
    }

    //Show the item in the fridge when it was bought
    void ShowItemInFridge(GameObject[] items, int numberOf)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (numberOf == i + 1)
            {
                items[i].SetActive(true);
            }
        }
    }

    
    //Spawn item on the table when player buys it
    void SpawnItemOnTable(GameObject item, Vector3 rotation)
    {
        GameObject[] spawnpoints = { spawnpoint1, spawnpoint2, spawnpoint3, spawnpoint4 };

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (playerManager.player.isSpawnPointTaken[i] == false)
            {
                playerManager.player.tableItems[i] = Instantiate(item, new Vector3(spawnpoints[i].transform.position.x, item.transform.position.y, spawnpoints[i].transform.position.z), Quaternion.identity);
                playerManager.player.tableItems[i].SetActive(true);
                playerManager.player.tableItems[i].transform.Rotate(rotation);
                playerManager.player.isSpawnPointTaken[i] = true;

                break;
            }
        }
    }
}
