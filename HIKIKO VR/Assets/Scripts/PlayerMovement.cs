using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    //public CharacterController controller;
    public float speed = 0.5f;
    public Transform trans;
    //public Rigidbody rb;
    public Vector3 movement;
    public Transform porta;
    private int trigger = 0;
    public Material sky;
    public Animator animator;
    public Animator stanza;
    public GameObject luce;
    public GameObject ogg;
    private Vector3 ogg_pos;
    public bool ogg_transf = false;
    private bool activeAudio = true;

    private void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        luce.SetActive(false);
        ogg_pos = ogg.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        /*if (SceneManager.GetActiveScene().name == "Bedroom")
        {
            movement = trans.position;
            movement.x = 0;
            movement.y = 0;
        }*/
        //transform.Translate(trans.position * Time.deltaTime);
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);*/
    }
    private void FixedUpdate()
    {

        /*if (SceneManager.GetActiveScene().name == "Bedroom")
        {
            if (transform.position.z < 2f || porta.transform.transform.eulerAngles.y > 275f)
            {
                moveCharacther(movement);
                rb.isKinematic = false;
                trigger++;
            }
            else
            {
                rb.isKinematic = true;
                trigger++;
            }
            if (trigger > 3 && transform.position.z > 20.1f)
            {
                rb.isKinematic = true;
                RenderSettings.skybox = sky;
            }

        }*///PROVA MOVIMENTO PERSONAGGIO

        
            /*if (porta.transform.eulerAngles.y < 100)
            {
                animator.SetTrigger("Go");
            }*/
            if (Input.GetKey("g") || ogg_pos != ogg.transform.position)
            {
                ActiveAudio();
                //GameObject.Find("CubeobJ").GetComponent<SkyObjects>().anim = true;
                luce.SetActive(true);
                foreach (GameObject tmp in GameObject.FindGameObjectsWithTag("muro"))
            {
                tmp.GetComponent<Animator>().SetTrigger("free");
            }
            //GameObject.Find("Muro_R").GetComponent<Animator>().SetTrigger("free");
                //GameObject.Find("Muro_L").GetComponent<Animator>().SetTrigger("free");
                //GameObject.Find("Muro_B").GetComponent<Animator>().SetTrigger("free");
                //GameObject.Find("Muro_F").GetComponent<Animator>().SetTrigger("free");
                //GameObject.Find("Soffitto").GetComponent<Animator>().SetTrigger("free");
            Destroy(GameObject.Find("Porta").GetComponent<HingeJoint>());
            Destroy(GameObject.Find("Porta").GetComponent<HingeJointListener>());
            //Destroy(GameObject.Find("Porta").GetComponent<Rigidbody>());
            

            //GameObject.Find("mura").GetComponent<Rigidbody>().useGravity = true;
            ogg_transf = true;

                RenderSettings.skybox = sky;
            }
            
        
        
        
        
        if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        


    }
    void moveCharacther(Vector3 direction)
    {
        //rb.AddForce(direction * speed);
        //Debug.Log(direction);
    }
    void ActiveAudio()
    {
        if (activeAudio == true)
        {
            FindObjectOfType<AudioManager>().Play("Sky");
            activeAudio = false;
        }
    }
    
}
