using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void MoveToMultiplayer()
    {
        SceneManager.LoadScene("MP Default theme");
    }
    public void MoveToSingleplayer()
    {
        SceneManager.LoadScene("Default theme");
    }
}
