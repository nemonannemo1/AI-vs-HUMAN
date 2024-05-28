using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fire ball"))
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
        }
        if (other.CompareTag("psycho ball"))
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
        }
    }
}
