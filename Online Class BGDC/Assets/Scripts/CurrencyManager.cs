using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public float gold;
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
}
