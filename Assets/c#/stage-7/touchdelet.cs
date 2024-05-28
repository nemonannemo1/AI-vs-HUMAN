using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchdelet : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = gameObject;
        coin.GetComponent<BoxCollider>().isTrigger = true;
        coin.GetComponent<Rigidbody>().useGravity = false;
        coin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        coin.SetActive(false);
    }
}
