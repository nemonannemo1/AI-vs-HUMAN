using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage1 = 2.0f;
        }
    }
}
