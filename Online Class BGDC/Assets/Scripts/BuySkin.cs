using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySkin : MonoBehaviour
{
    private CurrencyManager currencyManager;
    private ShopSkinButton shopSkinButton;
    public float rareSkinPrice;
    public float legendSkinPrice;

    private void Start()
    {
        currencyManager = GameObject.Find("CurrencyManager").GetComponent<CurrencyManager>();
        shopSkinButton = GetComponent<ShopSkinButton>();
    }
    public void BuyRareSkin()
    {
        PlayerPrefs.SetString("rareSkinStatus", "own");
        Debug.Log("Skin purchased!");
        currencyManager.ChangeCurrency(-rareSkinPrice);
        shopSkinButton.rareSkinStatus = PlayerPrefs.GetString("rareSkinStatus", "not own");
    }
    public void BuyLegendSkin()
    {
        PlayerPrefs.SetString("legendSkinStatus", "own");
        Debug.Log("Skin purchased!");
        currencyManager.ChangeCurrency(-legendSkinPrice);
        shopSkinButton.legendSkinStatus = PlayerPrefs.GetString("legendSkinStatus", "not own");
    }
}
