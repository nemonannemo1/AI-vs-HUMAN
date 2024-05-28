using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeoutfade : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    private float a = 1.0f;

    public float b = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CanvasGroup>();
        canvasGroup = gameObject.GetComponent<CanvasGroup>();

        a = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        canvasGroup.alpha = a;
        a = a + Time.deltaTime;
    }
}
