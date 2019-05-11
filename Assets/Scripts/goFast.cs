using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goFast : MonoBehaviour
{
    public GameObject balll;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("paddle"))
        {
            Destroy(balll);
            FindObjectOfType<PaddleScript>().incSpeed();
            Invoke("decreaseSp", 4);
        }
    }
    public void decreaseSp()
    {
        FindObjectOfType<PaddleScript>().decSpeed();
    }
}