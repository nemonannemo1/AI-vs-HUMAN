using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class disappersound : MonoBehaviour
{
    public GameObject door;

    public AudioSource a;
    bool b = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!b)
        {
            if (!door.activeSelf)
            {
                Debug.Log("open");
                a.Play();
                b = true;
            }
        }
        
    }
}
