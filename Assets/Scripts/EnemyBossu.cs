using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool afectedByLight;
    public int maxSpeed = 2;
    public Transform player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //mover en direccion del jugador
        Vector3 dif = Vector3.Normalize(gameObject.transform.position-player.position);
        if (true)
        {
            
        }

    }

}
