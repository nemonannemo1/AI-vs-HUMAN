using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fivedel : MonoBehaviour
{
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!coin1.activeSelf && !coin2.activeSelf && !coin3.activeSelf && !coin4.activeSelf && !coin5.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
