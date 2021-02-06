using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "PlayerUnit")
        {
            col.transform.position = new Vector3(target.position.x,target.position.y,target.position.z);
        }
    }
}
