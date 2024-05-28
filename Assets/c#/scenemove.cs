using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemove : MonoBehaviour
{
    [SerializeField] Scene _nextScene = Scene.title;
    [SerializeField] UnityEngine.Events.UnityEvent _goalInCallback;

    public CanvasGroup a;
    public float b = 0.0f;
    bool c = false;

    public GameObject baseup;
    public bool d = false;
    public float e = 0.0f;

    public AudioSource bgm;
    public float f = 1.0f;
    public bool g = false;
    // Start is called before the first frame update
    void Start()
    {
        b = 0.0f;
        c = false;
        d = false;
        g = false;
        e = 0.0f;
        f = 1.0f;
    }
    public enum Scene
    {
        title,
        to2,
        to3,
        to4,
        to5,
        to6,
        to7,
        to8,
        toscore,
        stage1,
        stage2,
        stage3,
        stage4,
        stage5,
        stage6,
        stage7,
        stage8,
        score,

    }

    // Update is called once per frame
    void Update()
    {
        
        a.alpha = b;
        

        if (c == true)
        {
            
            b = b + Time.deltaTime;
            
        }

        if (b >= 1.0f)
        {
            _goalInCallback.Invoke();
            Next();
        }

        baseup.transform.localScale = new Vector3(1f, e, 1f);
        if (d == true)
        {
            e = e + 8.5f* Time.deltaTime;
        }

        if (g == true)
        {
            f = f - 5 * Time.deltaTime;
            if ( f <= 0)
            {
                f = 0;
            }
        }
        bgm.volume = f;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            c = true;
            d = true;
            g = true;
        }
    }
    public void Next()
    {
        
       
            Debug.Log("Next");
            SceneManager.LoadScene(_nextScene.ToString());
        
        

    }

}
