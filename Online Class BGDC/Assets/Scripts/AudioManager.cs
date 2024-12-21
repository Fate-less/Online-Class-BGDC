using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [Header("Mainmenu")]
    public AudioClip buttonHoverSFX;
    public AudioClip buySkinSFX;
    public AudioClip buttonSelectSFX;

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
