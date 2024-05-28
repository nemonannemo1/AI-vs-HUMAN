using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadein : MonoBehaviour
{
    public GameObject fade;
    private CanvasGroup canvasGroup;
    private float a = 0.0f;
    public bool b  = false;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = fade.GetComponent<CanvasGroup>();

        a = 0.0f;
        b = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (b == true)
        {
            a = a + Time.deltaTime;
            canvasGroup.alpha = a;
            if (a >= 1.0f)
            {
                a = 1.0f;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other .CompareTag("Player"))
        {
            b = true;
        }
    }
}
