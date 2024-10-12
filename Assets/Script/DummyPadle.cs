using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyPadle : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField]
    private Transform myBall;

    [SerializeField]
    private float speed;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        //Não pode ser implementada. Muito inteligente e atravessa as paredes.
        //transform.position = new Vector2(transform.position.x, myBall.position.y);
        //

        float diference = transform.position.y - myBall.position.y;
        rb2d.velocity = new Vector2(0, -diference * speed);


    }
}
