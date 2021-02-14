using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCharacterController : MonoBehaviour
{
    bool IsLampOn = true;
    float horizontal = 0, vertical = 0;
    public float speed = 3f;
    private Rigidbody2D rb;
    public bool itemGet;
    public GameObject Spritemask;
    public GameObject Inventory;
    public GameObject Key;
    bool keyGet;
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

        if (Input.GetKeyDown(KeyCode.Z))
        {
            IsLampOn = !IsLampOn;
        }
        if (IsLampOn)
        {
            mask.SetActive(true);
        }
        else
        {
            mask.SetActive(false);
        }

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

        if (Input.GetKeyDown(KeyCode.C))
        {
            OpenInventory();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            keyGet = !keyGet;
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    void OpenInventory()
    {
        Inventory.SetActive(!Inventory.activeSelf);
        if(keyGet)
        {
            Key.SetActive(!Key.activeSelf);
        }
    }
    
}
