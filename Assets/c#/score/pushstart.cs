using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pushstart : MonoBehaviour
{
    public AudioSource bgm;
    bool a = false;
    bool b = true;

    public CanvasGroup fad;
    public float fade = 0.0f;

    public GameObject p1;
    public GameObject p2;
   
    // Start is called before the first frame update
    void Start()
    {
        a = false;
        b = true;
        fade = 0.0f;

        p1.SetActive(false);
        p2.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        fad.alpha = fade;
        if (b == true)
        {

            if (Input.anyKeyDown)
            {
                
                if (p2.activeSelf)
                {
                    bgm.Play();
                    a = true;
                    b = false;
                }

                if (p1.activeSelf)
                {
                    p2.SetActive(true);
                }

                
                if (!p1.activeSelf)
                {
                    p1.SetActive(true);
                }

                
                
                
               
                
            }
        }
        
        if (a == true)
        {
            fade = fade + 0.3f* Time.deltaTime;

            if (fade >= 1.0f)
            {
                fade = 1.0f;
            }
            if (!bgm.isPlaying)
            {
                // 음악이 끝나면 실행할 작업
                SceneManager.LoadScene("stage1");
            }
        }
        
    }
}
