using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject interfaceItem;
    bool IsPicked;
    public GameObject player;
    MainCharacterController mc;
    // Update is called once per frame
    void Start() {
        mc = player.GetComponent<MainCharacterController>();
    }
    void Update()
    {
        if(IsPicked)
        {

            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {

        IsPicked = true;
        mc.itemGet = true;
    }
}
