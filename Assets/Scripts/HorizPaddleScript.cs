using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizPaddleScript : MonoBehaviour
{

    public float speed = 10.0f;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;
    public Rigidbody2D rb;
    public float boundX = -9f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveRight))
        {
            rb.velocity = new Vector2(speed,0);
        }
        else if (Input.GetKey(moveLeft))
        {
            rb.velocity = new Vector2(speed * -1,0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
        var pos = transform.position;
        if (pos.x < boundX)
        {
            pos.x = boundX;
        }
        else if (pos.x > -boundX)
        {
            pos.x = -boundX;        }
        transform.position = pos;
    }
}
