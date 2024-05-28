using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pushtitle : MonoBehaviour
{
    public GameObject title;
    public CanvasGroup a;
    float b = 0.0f;
    bool c = false;

    float d = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.alpha = b;
        if (c == true)
        {
            b = b + Time.deltaTime;
        }
        if (title.activeSelf)
        {
            d = d - Time.deltaTime;
            if (d <= 0.0f)
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

            if (Input.anyKey)
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

        if (b >= 1.0f)
        {
            SceneManager.LoadScene("title");
            staticobj.score = 0;
            staticox.stage1 = 0;
            staticox.stage2 = 0;
            staticox.stage3 = 0;
            staticox.stage4 = 0;
            staticox.stage5 = 0;
            staticox.stage6 = 0;
            staticox.stage7 = 0;
            staticox.stage8 = 0;
        }
    }
}
