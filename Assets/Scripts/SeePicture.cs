using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePicture : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject interfaceItem;
    bool inTriggerZone = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inTriggerZone && Input.GetKeyDown(KeyCode.X) && !interfaceItem.activeInHierarchy)
        {
            interfaceItem.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.X))
        {
            interfaceItem.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "PlayerUnit")
        {
            inTriggerZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "PlayerUnit")
        {
            interfaceItem.SetActive(false);
            inTriggerZone = false;
        }
    }
}
