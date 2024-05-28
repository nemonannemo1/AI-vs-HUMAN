using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticchoice : MonoBehaviour
{
    public float st1;
    public float st2;
    public float st3;
    public float st4;
    public float st5;
    public float st6;
    public float st7;
    public float st8;

    public GameObject humst1;
    public GameObject humst2;
    public GameObject humst3;
    public GameObject humst4;
    public GameObject humst5;
    public GameObject humst6;
    public GameObject humst7;
    public GameObject humst8;
    public GameObject AIst1;
    public GameObject AIst2;
    public GameObject AIst3;
    public GameObject AIst4;
    public GameObject AIst5;
    public GameObject AIst6;
    public GameObject AIst7;
    public GameObject AIst8;
    
    // Start is called before the first frame update
    void Start()
    {
        st1 = staticox.stage1;
        st2 = staticox.stage2;
        st3 = staticox.stage3;
        st4 = staticox.stage4;
        st5 = staticox.stage5;
        st6 = staticox.stage6;
        st7 = staticox.stage7;
        st8 = staticox.stage8;
    }

    // Update is called once per frame
    void Update()
    {
        if (st1 <= 0.5f)
        {
            humst1.SetActive(false);
            AIst1.SetActive(false);
        }
        else if (st1 >= 1.5f)
        {
            humst1.SetActive(true);
            AIst1.SetActive(false);
        }
        else
        {
            humst1.SetActive(false); 
            AIst1.SetActive(true);
        }
        //--
        if (st2 <= 0.5f)
        {
            humst2.SetActive(false);
            AIst2.SetActive(false);
        }
        else if (st2 >= 1.5f)
        {
            humst2.SetActive(true);
            AIst2.SetActive(false);
        }
        else
        {
            humst2.SetActive(false);
            AIst2.SetActive(true);
        }
        //--
        if (st3 <= 0.5f)
        {
            humst3.SetActive(false);
            AIst3.SetActive(false);
        }
        else if (st3 >= 1.5f)
        {
            humst3.SetActive(true);
            AIst3.SetActive(false);
        }
        else
        {
            humst3.SetActive(false);
            AIst3.SetActive(true);
        }
        //--
        if (st4 <= 0.5f)
        {
            humst4.SetActive(false);
            AIst4.SetActive(false);
        }
        else if (st4 >= 1.5f)
        {
            humst4.SetActive(true);
            AIst4.SetActive(false);
        }
        else
        {
            humst4.SetActive(false);
            AIst4.SetActive(true);
        }
        //--
        if (st5 <= 0.5f)
        {
            humst5.SetActive(false);
            AIst5.SetActive(false);
        }
        else if (st5 >= 1.5f)
        {
            humst5.SetActive(true);
            AIst5.SetActive(false);
        }
        else
        {
            humst5.SetActive(false);
            AIst5.SetActive(true);
        }
        //--
        if (st6 <= 0.5f)
        {
            humst6.SetActive(false);
            AIst6.SetActive(false);
        }
        else if (st6 >= 1.5f)
        {
            humst6.SetActive(true);
            AIst6.SetActive(false);
        }
        else
        {
            humst6.SetActive(false);
            AIst6.SetActive(true);
        }
        //--
        if (st7 <= 0.5f)
        {
            humst7.SetActive(false);
            AIst7.SetActive(false);
        }
        else if (st7 >= 1.5f)
        {
            humst7.SetActive(true);
            AIst7.SetActive(false);
        }
        else
        {
            humst7.SetActive(false);
            AIst7.SetActive(true);
        }
        //--
        if (st8 <= 0.5f)
        {
            humst8.SetActive(false);
            AIst8.SetActive(false);
        }
        else if (st8 >= 1.5f)
        {
            humst8.SetActive(true);
            AIst8.SetActive(false);
        }
        else
        {
            humst8.SetActive(false);
            AIst8.SetActive(true);
        }
        
    }
}
