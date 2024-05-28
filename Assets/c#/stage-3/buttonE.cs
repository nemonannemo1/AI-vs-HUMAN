using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonE : MonoBehaviour
{
    //1,3,6
    public GameObject b1;
    public GameObject b3;
    public GameObject b6;
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
            b1.SetActive(!b1.activeSelf);
            b6.SetActive(!b6.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
        if (other.CompareTag("psycho ball"))
        {
            b1.SetActive(!b1.activeSelf);
            b6.SetActive(!b6.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
    }
}
