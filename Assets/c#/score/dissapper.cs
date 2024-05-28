using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class dissapper : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        b.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a.activeSelf)
        {
            b.SetActive(true);
        }
        
    }
}
