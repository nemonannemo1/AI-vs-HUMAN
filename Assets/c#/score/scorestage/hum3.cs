using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage3 = 2.0f;
        }
    }
}
