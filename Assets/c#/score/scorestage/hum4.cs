using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage4 = 2.0f;
        }
    }
}
