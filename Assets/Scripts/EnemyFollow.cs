using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PlayerUnit").GetComponent<Transform>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) < 6)
        {
            if(Vector2.Distance(transform.position, target.position) > 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2 (target.position.x, target.position.y), speed * Time.deltaTime);
            }
        }
        if (transform.position.x - target.position.x > 0)  //Si hay una tecla presionada al + personaje se voltea//
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (transform.position.x - target.position.x < 0)   //Si hay una tecla presionada al - personaje se voltea//
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }
}
