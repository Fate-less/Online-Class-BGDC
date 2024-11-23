using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainmenuButtons : MonoBehaviour
{
    //public Button startButton;

    public void MoveToGameplay()
    {
        SceneManager.LoadScene("Default theme");
    }
}
