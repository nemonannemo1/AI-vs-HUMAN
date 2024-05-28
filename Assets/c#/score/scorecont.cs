using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecont : MonoBehaviour
{
    //--------------------
    public AudioSource bgm;
    //-----------------
    public float a;
    public GameObject star0;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject star6;
    public GameObject star7;
    public GameObject star8;


    //---------------------

    public GameObject alpa;
    public GameObject alpa2;
    public GameObject alpa3;
    public GameObject alpa4;
    public GameObject alpa5;
    public float alppa = 0.0f;

    public GameObject title;

    public bool end = true;
    // Start is called before the first frame update
    void Start()
    {
        alppa = 0.0f;
        star0.SetActive(false);
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        star4.SetActive(false);
        star5.SetActive(false);
        star6.SetActive(false);
        star7.SetActive(false);
        star8.SetActive(false);
       
        alpa.SetActive(false);
        alpa2.SetActive(false);
        alpa3.SetActive(false);    
        alpa4.SetActive(false);
        alpa5.SetActive(false);

        title.SetActive(false);
    }

   
    // Update is called once per frame
    void Update()
    {
        float b = staticobj.score;
        a = b;
        Debug.Log("a");
        if (a <= 0.1f)
        {
            star0.SetActive(true);
        }
        else if (a == 12.5f)
        {
            star1.SetActive(true);
        }
        else if (a == 25)
        {
            star2.SetActive(true);
        }
        else if (a == 37.5f)
        {
            star3.SetActive(true);
        }
        else if (a == 50)
        {
            star4.SetActive(true);
        }
        else if (a == 62.5f)
        {
            star5.SetActive(true);
        }
        else if (a == 75)
        {
            star6.SetActive(true);
        }
        else if (a == 87.5f)
        {
            star7.SetActive(true);
        }
        else if (a == 100)
        {
            star8.SetActive(true);
        }
        //-------------------

        if (end == true)
        {
            alppa = alppa + 1.5f * Time.deltaTime;
        }
        else if (end == false)
        {
            alppa = 0.0f;
        }
        
        

        if (alppa >= 1f)
        {
            if (alpa5.activeSelf && alpa4.activeSelf && alpa3.activeSelf && alpa2.activeSelf && !alpa.activeSelf && alppa >= 1f)
            {
                bgm.Play();
                alpa.SetActive(true);
                alppa = 0f;
                
            }
            else if (alpa5.activeSelf && alpa4.activeSelf && alpa3.activeSelf && !alpa2.activeSelf && !alpa.activeSelf && alppa >= 1f)
            {
                alpa2.SetActive(true);
                alppa = 0f;
                bgm.Play();
            }
            else if (alpa5.activeSelf && alpa4.activeSelf && !alpa3.activeSelf && !alpa2.activeSelf && !alpa.activeSelf && alppa >= 1f)
            {
                alpa3.SetActive(true);
                alppa = 0f;
                bgm.Play();
            }
            else if (alpa5.activeSelf && !alpa4.activeSelf && !alpa3.activeSelf && !alpa2.activeSelf && !alpa.activeSelf && alppa >= 1f)
            {
                alpa4.SetActive(true);
                alppa = 0f;
                bgm.Play();
            }
            else if (!alpa5.activeSelf && !alpa4.activeSelf && !alpa3.activeSelf && !alpa2.activeSelf && !alpa.activeSelf && alppa >= 1f)
            {
                alpa5.SetActive(true);
                alppa = 0f;
                bgm.Play();
            }
            if (alpa5.activeSelf && alpa4.activeSelf && alpa3.activeSelf && alpa2.activeSelf && alpa.activeSelf && alppa >= 1f)
            {
                title.SetActive(true);
                alppa = 0f;
                end = false;

            }

        }
        else
        {
            
            return;
        }
    }

}
