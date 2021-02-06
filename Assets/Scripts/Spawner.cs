using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawner;
    int counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 120)
        {
            Instantiate(spawner);
        }
    }
}
