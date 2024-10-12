using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCtrl : MonoBehaviour
{

    private Rigidbody2D rb2d;



    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector2 startSpeed = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
        startSpeed.Normalize();
        rb2d.velocity = startSpeed * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            rb2d.velocity += rb2d.velocity * 0.05f;
        }
    }
}
