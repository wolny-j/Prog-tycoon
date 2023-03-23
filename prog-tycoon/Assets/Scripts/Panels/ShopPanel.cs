using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsible for displaying the shop and buying items 
public class ShopPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] List<GameObject> waterBottles;
    [SerializeField] List<GameObject> energyDrinks;
    [Header("Other items")]
    [SerializeField] GameObject tableCoffeeCup;
    [SerializeField] GameObject tableSandwich, gamingConsole;
    [Header("Spawnpoints")]
    [SerializeField] List<GameObject> spawnpoints;



    //Functions used by the buttons to buy items from the shop panel
    public void BuyEnergyDrink()
    {
        if (playerManager.player.money >= 8)
        {
            playerManager.player.energyDrink++;
            playerManager.player.money -= 8;

            ShowItemInFridge(energyDrinks, playerManager.player.energyDrink);
        }
    }
    public void BuyWaterBottle()
    {
        if (playerManager.player.money >= 7)
        {

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
    public void BuyConsole()
    {
        if (playerManager.player.money >= 400)
        {
            playerManager.player.gamingConsole = true;
            playerManager.player.money -= 400;
            gamingConsole.SetActive(true);
        }
    }

    //Show the item in the fridge when it was bought
    void ShowItemInFridge(List<GameObject> items, int numberOf)
    {
        for (int i = 0; i < items.Count; i++)
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
        for (int i = 0; i < spawnpoints.Count; i++)
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
