using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourhreturn : MonoBehaviour
{
    public GameObject play;
    public GameObject stop;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = stop.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            play.transform.position = new Vector3(-6.3f, -0.2f, 0);
            stop.transform.localPosition = Vector3.zero;
            rb.velocity = Vector3.zero; // 선형 가속도를 0으로 만듭니다.
            rb.angularVelocity = Vector3.zero;
        }
        
    }
}
