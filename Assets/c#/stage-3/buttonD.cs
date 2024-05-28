using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonD : MonoBehaviour
{
    //2,3,5
    public GameObject b2;
    public GameObject b5;
    public GameObject b3;
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
            b5.SetActive(!b5.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
        if (other.CompareTag("psycho ball"))
        {
            b2.SetActive(!b2.activeSelf);
            b5.SetActive(!b5.activeSelf);
            b3.SetActive(!b3.activeSelf);
        }
    }
}
