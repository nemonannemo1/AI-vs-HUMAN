using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            staticox.stage1 = 1.0f;
        }
    }
}
