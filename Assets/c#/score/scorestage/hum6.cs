using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum6 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage6 = 2.0f;
        }
    }
}
