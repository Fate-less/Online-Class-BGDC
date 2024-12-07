using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSkinButton : MonoBehaviour
{
    private CurrencyManager currencyManager;
    public Button rareSkinButton;
    public Button legendSkinButton;
    private BuySkin buySkin;
    [HideInInspector] public string rareSkinStatus;
    [HideInInspector] public string legendSkinStatus;
    [Header("Status")]
    public GameObject rareSkinLock;
    public GameObject legendSkinLock;
    public GameObject rareSkinStatusTMP;
    public GameObject legendSkinStatusTMP;
    private void Start()
    {
        rareSkinStatus = PlayerPrefs.GetString("rareSkinStatus", "not own");
        legendSkinStatus = PlayerPrefs.GetString("legendSkinStatus", "not own");
        currencyManager = GameObject.Find("CurrencyManager").GetComponent<CurrencyManager>();
        buySkin = GetComponent<BuySkin>();
    }

    private void Update()
    {
        if(rareSkinStatus == "own" || currencyManager.gold < buySkin.rareSkinPrice)
        {
            rareSkinButton.interactable = false;
            if (currencyManager.gold < buySkin.rareSkinPrice)
            {
                rareSkinLock.SetActive(true);
                rareSkinStatusTMP.SetActive(false);
            }
            else
            {
                rareSkinStatusTMP.SetActive(true);
                rareSkinLock.SetActive(false);
            }

        }
        else
        {
            rareSkinButton.interactable = true;
            rareSkinLock.SetActive(false);
            rareSkinStatusTMP.SetActive(false);
        }
        if (legendSkinStatus == "own" || currencyManager.gold < buySkin.legendSkinPrice)
        {
            legendSkinButton.interactable = false;
            if (currencyManager.gold < buySkin.legendSkinPrice)
            {
                legendSkinLock.SetActive(true);
                legendSkinStatusTMP.SetActive(false);
            }
            else
            {
                legendSkinStatusTMP.SetActive(true);
                legendSkinLock.SetActive(false);
            }
        }
        else
        {
            legendSkinButton.interactable = true;
            legendSkinLock.SetActive(false);
            legendSkinStatusTMP.SetActive(false);
        }
    }
}
