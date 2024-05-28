using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basestartbgm : MonoBehaviour
{
    public GameObject base1;
    public AudioSource effect;
    float c;
    // Start is called before the first frame update
    void Start()
    {
        base1 = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = base1.transform.localScale;
        c  = a.y;

        if (c >= 0.1f)
        {
            effect.Play();
        }
    }
}
