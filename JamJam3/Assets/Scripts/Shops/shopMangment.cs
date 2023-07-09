using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public int coins;
    public TMP_Text coinsUI;
    public shopItem[] shopItems;
    public shopTemplete[] shopPanels;
    public Button[] buyButton;
    void Start()
    {

        coinsUI.text = "coins: " + coins.ToString();
        loadPanels();
        checkCanBuy();


    }

    // Update is called once per frame
    void Update()
    {
        checkCanBuy();


    }

    public void addCoins()
    {
        coins++;
        coinsUI.text = "coins: " + coins.ToString();
    }

    public void loadPanels()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleText.text = shopItems[i].title;
            shopPanels[i].descriptionText.text = shopItems[i].description;
            shopPanels[i].costText.text = "Coins: " + shopItems[i].cost.ToString();
        }
    }

    public void checkCanBuy()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            if (coins >= shopItems[i].cost)
                buyButton[i].interactable = true;
            else
                buyButton[i].interactable = false;

        }
    }
    public void buyItem(int buttonNum)
    {
        if(coins >= shopItems[buttonNum].cost)
        {
            coins = coins - shopItems[buttonNum].cost;
            coinsUI.text = "coins: " + coins.ToString();
            checkCanBuy();
        }
    }
}
