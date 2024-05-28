using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class code : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        DownKeyCheck();
    }


    void DownKeyCheck()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log(100000);
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code))
                {
                    //処理を書く
                    Debug.Log(code);
                    break;
                }
            }
        }
    }
}
