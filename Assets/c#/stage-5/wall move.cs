using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmove : MonoBehaviour
{
    public GameObject wall;
    public float a = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        wall = gameObject;
        a = 3.2f;
    }

    // Update is called once per frame
    void Update()
    {
        wall.transform.Translate(Vector3.right * a * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        a = a * -1.0F;
        
    }

    
}
