using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volum : MonoBehaviour
{
    public GameObject volumPrefab;

    public AudioSource volumAudioSource;
    float a = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volumAudioSource.volume = a;

        if (volumPrefab.activeSelf)
        {
            a = a - 1 * Time.deltaTime;
        }

        if (a <= 0)
        {
            a = 0;
        }
    }
}
