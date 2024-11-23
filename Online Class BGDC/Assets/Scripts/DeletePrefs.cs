using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefs : MonoBehaviour
{
    public static DeletePrefs instance;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.Log("sudah ada pref managernya");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void DeleteScoreSave()
    {
        PlayerPrefs.DeleteKey("scoreP1");
        PlayerPrefs.DeleteKey("scoreP2");
    }
    public void DeleteAllSave()
    {
        PlayerPrefs.DeleteAll();
    }
    /*
     * Playerprefs > Set, Get, Delete
     * 
     * Set > Nyimpen data
     * Get > Narik data
     * Delete > Ngehapus data
     * Data Type > Float, Int, String
     */
}
