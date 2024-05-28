using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public Rigidbody rb;
    public float attack = 700.0f;
    public bool rig = true;

    // Start is called before the first frame update
    void Awake()
    {
        rig = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            attack = 900.0f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            attack = -900.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
                rb.AddForce(Vector3.right * attack);
           
        }
        if (other.CompareTag("psycho enemy"))
        {
            gameObject.SetActive(false);
        }
        if (other.CompareTag("fire enemy"))
        {
            gameObject.SetActive(false);
        }
        if (other.CompareTag("ground"))
        {
            gameObject.SetActive(false);

        }
        

    }
}
