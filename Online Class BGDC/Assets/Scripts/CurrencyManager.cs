using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public float gold = 0;
    public static CurrencyManager instance;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.Log("sudah ada managernya");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        gold = PlayerPrefs.GetFloat("Gold Currency", 0);
    }

    public void ChangeCurrency(float increment)
    {
        gold += increment;
        PlayerPrefs.SetFloat("Gold Currency", gold);
    }
}
