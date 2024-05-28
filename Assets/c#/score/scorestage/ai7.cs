using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai7 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage7 = 1.0f;
        }
    }
}
