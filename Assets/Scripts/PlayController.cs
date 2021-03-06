using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{


    float horizontal = 0, vertical = 0;
    public float speed = 3f;
    private Rigidbody2D rb;

    public GameObject Spritemask;
    GameObject mask;
    SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        mask = Instantiate(Spritemask, gameObject.transform);
        rb = GameObject.FindGameObjectWithTag("PlayerUnit").GetComponent<Rigidbody2D>(); //MAIN CHAR
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (horizontal > 0 && Mathf.Abs(horizontal) > 0.1)  //Si hay una tecla presionada al + personaje se voltea//
        {
            m_SpriteRenderer.flipX = true;
            mask.transform.eulerAngles = new Vector3(0,0,0);
        }
        else if (horizontal < 0 && Mathf.Abs(horizontal) > 0.1)   //Si hay una tecla presionada al - personaje se voltea//
        {
            m_SpriteRenderer.flipX = false;
            mask.transform.eulerAngles = new Vector3(0,0,180);
        }
        if (vertical > 0 && Mathf.Abs(vertical) > 0.1)  //Si hay una tecla presionada al + personaje se voltea//
        {
            mask.transform.eulerAngles = new Vector3(0,0,90);
        }
        else if (vertical < 0 && Mathf.Abs(vertical) > 0.1)   //Si hay una tecla presionada al - personaje se voltea//
        {
            mask.transform.eulerAngles = new Vector3(0,0,-90);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

}
