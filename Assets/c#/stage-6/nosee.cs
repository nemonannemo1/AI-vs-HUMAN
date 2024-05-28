using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nosee : MonoBehaviour
{
    public GameObject body;
    public float sc = 0.0f;
    public float t = 5.0f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        body.transform.localScale = new Vector3(sc, sc, sc);

        sc = sc - t * Time.deltaTime;

        if (sc <= 0.0f)
        {
            sc = 0.0f;
        }
        else if (sc >= 1.0f)
        {
            sc = 1.0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            t = -5.0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            t = 5.0f;
        }

    }
}
