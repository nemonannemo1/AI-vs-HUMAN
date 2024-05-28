using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonF : MonoBehaviour
{
    //3,4,5
    public GameObject b3;
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
            b4.SetActive(!b4.activeSelf);
            b5.SetActive(!b5.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
        if (other.CompareTag("psycho ball"))
        {
            b4.SetActive(!b4.activeSelf);
            b5.SetActive(!b5.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
    }
}
