using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fadeinstart : MonoBehaviour
{
    public CanvasGroup cg;
    bool st = false;
    public AudioSource source ;
    float a;
    float b;
    // Start is called before the first frame update
    void Start()
    {
        source.Stop();
        b = 1.0f;
        cg = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
       a = cg.alpha;
        if(st == false)
        {
            if (a >= 0.01f)
            {
                source.Play();
                
                st = true;
            }
        }

        if (st == true)
        {
             source.volume = b;
            b = b - 0.9f * Time.deltaTime;
        }
       
    }
}
