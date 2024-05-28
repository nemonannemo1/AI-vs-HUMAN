using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public bool move = false;

    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        move = false;

        body = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            
                body.transform.Translate(Vector3.right * 7f * Time.deltaTime);

            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("fire enemy"))
        {
            move = true;
        }
        if(other.CompareTag("psycho enemy"))
        {
            move = true; 
        }
        if (other.CompareTag("ground"))
        {
            move = false;
            body.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {
            move = false;
            body.SetActive(false);
        }
    }
}
