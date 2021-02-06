using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmolEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool afectedByLight;
    public int maxSpeed = 2;
    int counter = 0;
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //mover en direccion del jugador
        if (true)
        {
            rb.AddForce(maxSpeed) = new Vector3 ()
        }
        else
        {

        }
    }

}
