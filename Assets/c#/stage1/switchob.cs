using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchob : MonoBehaviour
{
    public GameObject fire;
    public GameObject psycho;
    // Start is called before the first frame update
    void Start()
    {
        psycho.SetActive(false);
        fire.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            psycho.SetActive(!psycho.activeSelf);
            fire.SetActive(!fire.activeSelf);
        }
        
    }
}
