using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllPrefs : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
}
