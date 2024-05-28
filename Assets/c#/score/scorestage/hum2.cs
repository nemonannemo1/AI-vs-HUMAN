using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage2 = 2.0f;
        }
    }
}
