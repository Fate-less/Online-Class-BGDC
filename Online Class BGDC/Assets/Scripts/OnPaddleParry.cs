using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPaddleParry : MonoBehaviour
{
    public BallAnimation ballAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log(collision.gameObject.name);
            ballAnim.playDoubleBounce();
        }
    }
}
