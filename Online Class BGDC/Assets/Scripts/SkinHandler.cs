using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinHandler : MonoBehaviour
{
    public string currentSkin;
    void Start()
    {
        //rarity = default, rare, legend
        currentSkin = PlayerPrefs.GetString("currentSkin", "default");
    }
}
