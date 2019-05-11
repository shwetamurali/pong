using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    public float speed = 11.0f;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public Rigidbody2D rb;
    public float boundY = 2.80f;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;
    public float boundX = -9.0f;
    bool horiz = false;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        if (transform.position.x == 0)
            horiz = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!horiz)
        {
            if (Input.GetKey(moveUp))
            {
                rb.velocity = new Vector2(0, speed);
            }
            else if (Input.GetKey(moveDown))
            {
                rb.velocity = new Vector2(0, speed * -1);
            }
            else
            {
                rb.velocity = new Vector2(0, 0);
            }
            var pos = transform.position;
            if (pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if (pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            transform.position = pos;
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
            if (Input.GetKey(moveRight))
            {
                rb.velocity = new Vector2(speed, 0);
            }
            else if (Input.GetKey(moveLeft))
            {
                rb.velocity = new Vector2(speed * -1, 0);
            }
            else
            {
                rb.velocity = new Vector2(0, 0);
            }
            var posi = transform.position;
            if (posi.x < boundX)
            {
                posi.x = boundX;
            }
            else if (posi.x > -boundX)
            {
                posi.x = -boundX;
            }
            transform.position = posi;
        }

    }
    public void incSpeed()
    {
        speed = 16.0f;
    }
    public void decSpeed()
    {
        speed = 10.0f;
    }
}
