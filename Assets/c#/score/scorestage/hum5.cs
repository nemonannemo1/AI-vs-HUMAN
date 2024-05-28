using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum5 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage5 = 2.0f;
        }
    }
}
