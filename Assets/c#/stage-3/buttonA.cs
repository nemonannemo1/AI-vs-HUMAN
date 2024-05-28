using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonA : MonoBehaviour
{
    //1,4,6
    public GameObject b1;
    public GameObject b4;
    public GameObject b6;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fire ball"))
        {
            Debug.Log("f");
            b1.SetActive(!b1.activeSelf);
            b4.SetActive(!b4.activeSelf);
            b6.SetActive(!b6.activeSelf);
        }
        if (other.CompareTag("psycho ball"))
        {
            Debug.Log("p");
            b1.SetActive(!b1.activeSelf);
            b4.SetActive(!b4.activeSelf);
            b6.SetActive(!b6.activeSelf);
        }
    }
}
