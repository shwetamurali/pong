using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {
    public GameObject ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("paddle"))
        {
            Destroy(ball);
            FindObjectOfType<AnimationPlay>().startAnim();
        }
    }

}
