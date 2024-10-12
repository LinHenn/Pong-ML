using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPadle : MonoBehaviour
{

    private Rigidbody2D rb2d;

    private float movVertical;

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
    void Update()
    {

        movVertical = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(0, movVertical * speed);

    }
}
