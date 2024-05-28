using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai4 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage4 = 1.0f;
        }
    }
}
