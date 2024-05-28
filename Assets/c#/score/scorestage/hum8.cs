using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum8 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage8 = 2.0f;
        }
    }
}
