using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonB : MonoBehaviour
{
    //2,4,5
    public GameObject b2;
    public GameObject b4;
    public GameObject b5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fire ball"))
        {
            b2.SetActive(!b2.activeSelf);
            b4.SetActive(!b4.activeSelf);
            b5.SetActive(!b5.activeSelf);
        }
        if (other.CompareTag("psycho ball"))
        {
            b2.SetActive(!b2.activeSelf);
            b4.SetActive(!b4.activeSelf);
            b5.SetActive(!b5.activeSelf);
        }
    }
}
