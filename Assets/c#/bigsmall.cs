using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigsmall : MonoBehaviour
{

    public GameObject a;
    public float b;
    bool c = true;
    // Start is called before the first frame update
    void Start()
    {
        a = gameObject;
        b = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.localPosition = new Vector3 (b,-23,0);

        if (b <= -92.0000f)
        {
            c = true;
           
        }
        if (b >= 92.0000f)
        {
            c = false;
           
        }

        if (c)
        {
            b = b + 100.0000f* Time.deltaTime;
        }

        if (!c)
        {
            b = b - 100.0000f * Time.deltaTime;
        }
    }
}
