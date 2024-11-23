using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinObjective : MonoBehaviour
{
    public string playerSide;
    private ScoreManager scoreManager;
    public BallMovement ballMovementScript;

    public void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if(playerSide == "Player 1")
            {
                scoreManager.ChangeScore(1,2);
            }
            else
            {
                scoreManager.ChangeScore(1,1);
            }
            scoreManager.changeMapCounter += 1;
            ballMovementScript.ResetPosition();
            if(scoreManager.changeMapCounter == 5)
            {
                SceneManager.LoadScene("Dark theme");
            }
        }
    }
}
