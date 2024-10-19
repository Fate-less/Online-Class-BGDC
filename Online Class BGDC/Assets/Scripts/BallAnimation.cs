using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{
    public Animator ballAnim;

    public void playDoubleBounce()
    {
        playBounce();
        StartCoroutine(delayAnim());
    }

    public void playBounce()
    {
        ballAnim.SetTrigger("Parry Hit");
    }

    IEnumerator delayAnim()
    {
        yield return new WaitForSeconds(0.5f);
        playBounce();
    }
}
