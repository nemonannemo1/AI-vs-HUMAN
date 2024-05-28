using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    
    private float a = 1.0f;

    public float b = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
        canvasGroup = gameObject.GetComponent<CanvasGroup>();

        a = 1.0f;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        canvasGroup.alpha = a;
        b = b - 0.25f * Time.deltaTime;
        if (b <= 0.0f)
        {
            b= 0.0f;
            a = a - 1f * Time.deltaTime;
            
            if (a <= 0.0f)
            {
                a = 0.0f;
            }
        }
       
    }
}
