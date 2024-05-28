using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button6 ) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            staticobj.score = 0;
            staticox.stage1 = 0;
            staticox.stage2 = 0;
            staticox.stage3 = 0;
            staticox.stage4 = 0;
            staticox.stage5 = 0;
            staticox.stage6 = 0;
            staticox.stage7 = 0;
            staticox.stage8 = 0;
            SceneManager.LoadScene("title");

        }
    }
}
