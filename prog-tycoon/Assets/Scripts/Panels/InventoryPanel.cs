using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script responsible for displaying player's inventory and using item from it 
public class InventoryPanel : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Text energyDrink, water;
    [SerializeField] GameObject bottleUI, energyDrinkUI;
    [Header("Bottles")]
    [SerializeField] GameObject bottle1;
    [SerializeField] GameObject bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12;
    [Header("Energy Drinks")]
    [SerializeField] GameObject energyDrink1;
    [SerializeField] GameObject energyDrink2, energyDrink3, energyDrink4, energyDrink5, energyDrink6;

    [Header("TableItems")]
    [SerializeField] GameObject tableEnergyDrink;
    [SerializeField] GameObject tableBottle, spawnpoint1, spawnpoint2, spawnpoint3, spawnpoint4;

    void OnEnable()
    {
        SetUpButtonsInPanel();
        UpdateItems();
    }

    //Functions used by the buttons in the panel. 
    public void UseEnergyDrink()
    {
        if (playerManager.player.energyDrink > 0)
        {
            GameObject[] energyDrinks = { energyDrink1, energyDrink2, energyDrink3, energyDrink4, energyDrink5, energyDrink6 };
            playerManager.player.energyDrinkUsage++;
            playerManager.player.energy += 30;
            playerManager.player.wellbeing -= (10 + (playerManager.player.energyDrinkUsage * 10));
            playerManager.player.energyDrink--;
            energyDrink.text = playerManager.player.energyDrink.ToString();
            DisappearItemsFromTheFridge(energyDrinks, playerManager.player.energyDrink);
            SpawnItemOnTable(tableEnergyDrink, new Vector3(-90, -180, 86.312f));
        }
    }

    public void UseWater()
    {
        if (playerManager.player.water > 0)
        {
            GameObject[] waterBottles = { bottle1, bottle2, bottle3, bottle4, bottle5, bottle6, bottle7, bottle8, bottle9, bottle10, bottle11, bottle12 };
            playerManager.player.hunger += 5;
            playerManager.player.wellbeing += 5;
            playerManager.player.water--;
            water.text = playerManager.player.water.ToString();
            DisappearItemsFromTheFridge(waterBottles, playerManager.player.water);
            SpawnItemOnTable(tableBottle, new Vector3(-90, 0, 0));
        }
    }

    //Update the infomration about number of the all items
    void UpdateItems()
    {
        energyDrink.text = playerManager.player.energyDrink.ToString();
        water.text = playerManager.player.water.ToString();
    }

    //Spawn item on the table when player uses it
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

    //Disappear the item from the fridge when it was bought
    void DisappearItemsFromTheFridge(GameObject[] items, int numberOf)
    {
        for (int i = items.Length; i > 0; i--)
        {
            if (numberOf == i)
            {
                items[i].SetActive(false);
            }
            else if (numberOf == 0)
            {
                items[0].SetActive(false);
            }
        }
    }

    //Show the buttons in the panel grid only when player has particular item
    void SetUpButtonsInPanel()
    {
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

}
