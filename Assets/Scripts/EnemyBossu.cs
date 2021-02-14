using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBossu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool afectedByLight;
    public Transform player;
    public int flashCounter;
    int flashTotal = 3;
    public float plusVelocity = 0.3f;
    EnemyFollow enemyFollow;
    int spawnDelay = 3;

    float timer;
    [SerializeField]
    public Vector3 spawn;

    void Start()
    {
        enemyFollow = gameObject.GetComponent<EnemyFollow>();
    }
    void Respawn()
    {
        float dist = Vector3.Distance(player.position,spawn);
        float ang = UnityEngine.Random.Range(0.0f, 6.28f);
        gameObject.transform.position = player.position+new Vector3((float)(dist*Math.Cos(ang)),(float)((dist*Math.Sin(ang))),0.0f);
        timer = 0;
        flashCounter = 0;
        flashTotal += 2;
        enemyFollow.speed += plusVelocity;
        return;
    }
    void Update()
    {
        if (flashCounter >= flashTotal)
        {
            gameObject.transform.position = new Vector3(1000,1000,0);
            timer += Time.deltaTime;
        }

        if(timer>spawnDelay)
        {
            Respawn();
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Lantern")
        {
            flashCounter += 1;
        }
    }

}
