using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float rand;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //GoBall();
        Invoke("GoBall", 2);
    }


    void GoBall()
    {
        rand = Random.RandomRange(0, 2);
        if (rand < 1) rb2d.AddForce(new Vector2(20, -15));
        else rb2d.AddForce(new Vector2(-20, -15));
    }
    
    void Update()
    {
        
    }
}
