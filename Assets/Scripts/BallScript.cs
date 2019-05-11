using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public Rigidbody2D rg;
    public GameObject objectt;
    GameObject m_MyInstantiated;

    // Use this for initialization
    void Start () {

        if (tag=="actual")
            Invoke("Move", 3);
        else if(tag=="ballP")
        {
            objectt.SetActive(false);
            Invoke("show", 10.5f);
            Invoke("Move", 10.5f);
        }
            
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void show()
    {
        objectt.SetActive(true);
    }
    public void Move()
    {
        float randomDirection = Random.RandomRange(0, 4);
        if(randomDirection==0)
            rg.AddForce(new Vector2(-40, 6)); 
        else if (randomDirection == 1)
            rg.AddForce(new Vector2(44, 2));
        else if (randomDirection ==2)
             rg.AddForce(new Vector2(22, -16));
        else
             rg.AddForce(new Vector2(-22, -16));
    }
    public void ResetPos()
    {
        rg.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
    void RestartGame()
    {
        Invoke("ResetPos", .5f);
        //ResetPos(); 
        Invoke("Move", 2);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("paddle"))
        {
            Vector2 vel;
            vel.x = rg.velocity.x;
            vel.y = (rg.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            rg.velocity = vel;
        }
    }

}
