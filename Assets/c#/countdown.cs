using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public float count = 30f;

    public TextMeshProUGUI countdown2;

    public CanvasGroup a;
    float b = 0.0f;
    // Start is called before the first frame update

    //スコアをメモする変数を宣言する
    private void Start()
    {
        b = 0.0f;
    }
    private void Update()
    {
        a.alpha = b;
        count = count - 1f * Time.deltaTime;
        if(count <= 0)
        {
            b = b + Time.deltaTime;
            count = 0;
            if (b >= 1.0f)
            {
                SceneManager.LoadScene("to3");
                
            }
           

        }
        int ccc = Mathf.FloorToInt(count);
        countdown2.text = ccc.ToString();
    }
    

}
