using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onemin : MonoBehaviour
{
    public float a = 60f;
    // Start is called before the first frame update
    void Start()
    {
        a = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        a = a - Time.deltaTime;
        if (a <= 0)
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
