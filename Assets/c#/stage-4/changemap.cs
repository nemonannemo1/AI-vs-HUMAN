using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemap : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public float c = 1f;
    public AudioSource change;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(true); 
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        c = c + 2f *Time.deltaTime;
        if (c >= 1.0f)
        {
            c = 1.0f;
        }
        if (c == 1.0f)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                //attack chandge
                if (a.activeSelf)
                {

                    a.SetActive(false);
                    b.SetActive(true);
                    c = 0.0f;
                    change.Play();
                }
                else if (b.activeSelf)
                {

                    a.SetActive(true);
                    b.SetActive(false);
                    c = 0.0f;
                    change.Play();

                }
                else
                {
                    return;
                }
            }
        }
        
    }
}
