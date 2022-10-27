using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Text energyDrink, water;


    void Start()
    {

    }

    void OnEnable()
    {
        playerManager = GameObject.Find("GameManager").GetComponent<PlayerManager>();
        energyDrink.text = playerManager.playerInventory.energyDrink.ToString();
        water.text = playerManager.playerInventory.water.ToString();
    }
    void Update()
    {

    }

    public void UseEnergyDrink()
    {
        if (playerManager.playerInventory.energyDrink > 0)
        {
            playerManager.playerInventory.energyDrinkUsage++;
            playerManager.player.energy += 20;
            playerManager.player.wellbeing -= (10 + (playerManager.playerInventory.energyDrinkUsage * 5));
            playerManager.playerInventory.energyDrink--;
            energyDrink.text = playerManager.playerInventory.energyDrink.ToString();
        }
    }
    public void UseWater()
    {
        if (playerManager.playerInventory.water > 0)
        {
            playerManager.player.hunger += 5;
            playerManager.playerInventory.water--;
            water.text = playerManager.playerInventory.water.ToString();
        }
    }
}
