using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class psychoenemy : MonoBehaviour
{
    public float speed = 1.0f;
    public bool move = false;
    public bool a = true;

    public float attackgage = 1f;
    public GameObject gage;

    public GameObject enemy;
    public Transform bodytrans;
    public AudioSource a3;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        gage.transform.localScale = new Vector3(attackgage, 1f, 1f);
        attackgage = attackgage + 0.3f * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
        if (attackgage >= 1f)
        {
            attackgage = 1f;
        }
        if (move == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (attackgage == 1f)
        {
            if (speed >= 0.5f)
            {
                bodytrans.rotation = Quaternion.Euler(0f, 180f, 0f);
                Instantiate(enemy, bodytrans.position, bodytrans.rotation);
                attackgage = 0f;
            }
            else if (speed <= -0.5f)
            {
                bodytrans.rotation = Quaternion.Euler(0f, 0f, 0f);

                Instantiate(enemy, bodytrans.position, bodytrans.rotation);
                attackgage = 0f;

            }
            else
            {

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("psycho ball"))
        {
            gameObject.SetActive(false);
            a3.Play();
        }

        
        if (other.CompareTag("ground"))
        {
            move = true;
        }
        
        if (other.CompareTag("wall"))
        {
            if (a == true)
            {
                if (speed >= 0.5f)
                {
                    speed = speed * -speed;
                    a= false;
                }
                else if (speed <= -0.5f)
                {
                    speed = speed * speed;
                    a = false;
                }
                else
                {
                    return;
                }
            }
            
            
        }
        if (other.CompareTag("fire enemy"))
        {
            if (a == true)
            {
                if (speed >= 0.5f)
                {
                    speed = speed * -speed;
                    a = false;
                }
                else if (speed <= -0.5f)
                {
                    speed = speed * speed;
                    a = false;
                }
                else
                {
                    return;
                }
            }
        }
        if (other.CompareTag("psycho enemy"))
        {
            if (a == true)
            {
                if (speed >= 0.5f)
                {
                    speed = speed * -speed;
                    a = false;
                }
                else if (speed <= -0.5f)
                {
                    speed = speed * speed;
                    a = false;
                }
                else
                {
                    return;
                }
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            a = true;
        }
        if (other.CompareTag("fire enemy"))
        {
            a = true;
        }
        if (other.CompareTag("psycho enemy"))
        {
            a = true;
        }
    }
}
