using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum7 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage7 = 2.0f;
        }
    }
}
