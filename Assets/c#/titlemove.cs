using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlemove : MonoBehaviour
{
    float a = 1.0f;
    bool b = false;
    GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        c = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        c.transform.localScale = new Vector3(a,a,a);
        if (a >= 1.0f)
        {
           b = false;
        }
        if (a <= 0.8f)
        {
            b = true;
        }

        if (b == true)
        {
            a = a + 0.1f * Time.deltaTime;
        }
        else
        {
            a = a -0.1f * Time.deltaTime;
        }
    }
}
