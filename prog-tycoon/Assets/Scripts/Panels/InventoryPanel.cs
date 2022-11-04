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
        energyDrink.text = playerManager.player.energyDrink.ToString();
        water.text = playerManager.player.water.ToString();
    }
    void Update()
    {

    }

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
        }
    }
}
