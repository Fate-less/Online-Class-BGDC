using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //singleton (bikin instance)
    public static ScoreManager instance;
    public int scoreP1;
    public int scoreP2;
    public int changeMapCounter;

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
