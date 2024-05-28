using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public CanvasGroup can;
    public float aaa = 0.0f;
    //-----------------
    public GameObject playerbody;
    public Rigidbody playerrb;
    public float jumppow = 400.0f;
    public float movespd = 4.0f;
    public Transform attack;

    public GameObject ball1;
    public GameObject ball2;

    public float attackgage = 1.0f;
    public GameObject attackgageob;
    public bool ground = false;

    public float life = 1.0f;
    public GameObject lifeob;

    public GameObject typefire;
    public GameObject typepsycho;

    public GameObject righttext;
    public GameObject lefttext;

    public ParticleSystem party;
    public float partygage = 1.0f;

    float kd = -8.43f;
    bool jumptime = true;

    //--------------
    public AudioSource jump;
    public AudioSource shout;

    bool water = false;
    // Start is called before the first frame update
    void Start()
    {
        jumppow = 400.0f;
    movespd = 4.0f;
    life = 1.0f;
        ground = true;
      //  ball1.SetActive(true);
      //  ball2.SetActive(false);
        typefire.SetActive(true);
        typepsycho.SetActive(false);
        righttext.SetActive(true);
        lefttext.SetActive(false);
        party.Stop();
        water = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        can.alpha = aaa;
        //-----------------------------]
        //Vector3 bodymove = playerbody.transform.position;
       // bodymove.z  = 0.098f;
        //bodymove.x = kd;
        //playerbody.transform.position = bodymove;
        //Debug.Log(Input.GetAxis("Horizontal"));
        ball1.transform.localRotation = Quaternion.Euler(0, 0, 0);
        ball2.transform.localRotation = Quaternion.Euler(0, 0, 0);

        Vector3 a = ball1.transform.localPosition;
        a.y = 0.0f;
        a.z = 0.0f;
        ball1.transform.localPosition = a;

        

        Vector3 b = ball2.transform.localPosition;
        b.y = 0.0f;
            b.z = 0.0f;
        ball2.transform.localPosition = b;

        playerbody.transform.localRotation = Quaternion.Euler(0, 0, 0);
        transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
        attackgageob.transform.localScale = new Vector3(attackgage,1.0f,1.0f);
        lifeob.transform.localScale = new Vector3(life,1.0f,1.0f);
     if (attackgage < 1.0f)
        {
            attackgage = attackgage + 1.2f * Time.deltaTime;
        }
     else if (attackgage > 1.0f)
        {
            attackgage = 1.0f;
        }
        if (water == false)
        {
            playerrb.useGravity = true;
            if (Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("change");
                righttext.SetActive(false);
                lefttext.SetActive(true);
                Debug.Log("move");
                playerbody.transform.Translate(Vector3.left * movespd * Time.deltaTime);

            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                righttext.SetActive(true);
                lefttext.SetActive(false);
                playerbody.transform.Translate(Vector3.right * movespd * Time.deltaTime);
                //kd = kd + 0.01f * movespd;
                //playerbody.transform.Translate(Vector3.right * movespd * Time.deltaTime);

            }
        
            if (ground == true)
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button5) || Input.GetKeyDown(KeyCode.Joystick1Button1))
                {
                    Debug.Log("JUMP");
                    if (jumptime == true)
                    {
                        playerrb.AddForce(Vector3.up * jumppow);
                        jumptime = false;
                        Invoke("times", .5f);
                        jump.Play();

                    }
                    ground = false;
                    party.Play();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                //attack chandge
                if (typefire.activeSelf)
                {

                    typefire.SetActive(false);
                    typepsycho.SetActive(true);
                }
                else if (typepsycho.activeSelf)
                {

                    typefire.SetActive(true);
                    typepsycho.SetActive(false);
                }
                else
                {
                    return;
                }
            }
            if (attackgage == 1.0f)
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button3))
                {
                    //attack
                    // ball1.transform.Translate(Vector3.up * jumppow);
                    if (typefire.activeSelf)
                    {
                        Instantiate(ball1, attack.position, attack.rotation);
                        shout.Play();
                        attackgage = 0.0f;
                    }
                    else if (typepsycho.activeSelf)
                    {
                        Instantiate(ball2, attack.position, attack.rotation);
                        attackgage = 0.0f;
                        shout.Play();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }

            if (life <= 0.1f)
            {
                aaa = aaa + Time.deltaTime;
                if (aaa >= 1.0f)
                {
                    SceneManager.LoadScene("to2");
                }

            if (life <= 0.0f)
            {
                life = 0.0f;
            }


            }
            if (party.gameObject.activeSelf)
            {
                partygage = partygage - 1.3f * Time.deltaTime;
                if (partygage <= 0)
                {
                    party.Stop();
                    partygage = 0f;

                }
            }
        if (partygage == 0f)

        {

            partygage = 1f;

        }

        else if (water == true)
        {
            playerrb.useGravity = false;
            if (Input.GetAxis("Horizontal") > 0)
            {
                Debug.Log("change");
                righttext.SetActive(false);
                lefttext.SetActive(true);
                Debug.Log("move");
                playerbody.transform.Translate(Vector3.left * movespd * Time.deltaTime);
                jump.volume = 1f;

            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                righttext.SetActive(true);
                lefttext.SetActive(false);
                playerbody.transform.Translate(Vector3.right * movespd * Time.deltaTime);
                //kd = kd + 0.01f * movespd;
                //playerbody.transform.Translate(Vector3.right * movespd * Time.deltaTime);
                jump.volume = 1f;
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                jump.volume = 1f;
                playerbody.transform.Translate(Vector3.up * movespd * Time.deltaTime);

            }
            if (Input.GetAxis("Vertical") < 0)
            {
                jump.volume = 1f;
                playerbody.transform.Translate(Vector3.down * movespd * Time.deltaTime);

            }
            if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
            {
                jump.volume = 0.0f;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            ground = true;
        }
        if (other.CompareTag("fire enemy"))
        {
            life = life - 0.1f;
        }
        if (other.CompareTag("psycho enemy"))
        {
            life = life - 0.1f;

        }
        if (other.CompareTag("attack"))
        {
            life = life - 0.1f;

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("fire enemy"))
        {
            life = life - 0.003f;
        }
        if (other.CompareTag("psycho enemy"))
        {
            life = life - 0.003f;

        }
        if (other.CompareTag("water"))
        {
            water = true;
            ground = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("water"))
        {
            water = false;
            ground = false;
        }
    }

    private void times()
    {
        jumptime = true;
    }
    
}
