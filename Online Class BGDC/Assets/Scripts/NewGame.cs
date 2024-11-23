using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    private DeletePrefs deletePref;

    private void Awake()
    {
        deletePref = GameObject.Find("PPrefsHandler").GetComponent<DeletePrefs>();
        deletePref.DeleteScoreSave();
    }
}
