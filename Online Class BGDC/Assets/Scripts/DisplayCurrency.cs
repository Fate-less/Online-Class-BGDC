using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCurrency : MonoBehaviour
{
    public TextMeshProUGUI currencyTMP;
    private CurrencyManager currencyManager;
    void Start()
    {
        currencyManager = GameObject.Find("CurrencyManager").GetComponent<CurrencyManager>();
    }

    void Update()
    {
        currencyTMP.text = "Currency: " + currencyManager.gold;
    }
}
