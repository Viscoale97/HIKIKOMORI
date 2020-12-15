using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navicella : MonoBehaviour
{
    private Rigidbody rb;
    public Transform ogg_interact_pos;
    public bool Active_navicella = false;
    private float moveSpeed = 10f;
    public GameObject joystick;
    private Vector3 deltaValue;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.transform.position.z >= 4f)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-(Vector3.forward));
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }*/

        if (transform.position != ogg_interact_pos.position && Active_navicella == false)
        {

            transform.position = Vector3.MoveTowards(transform.position, ogg_interact_pos.position, Time.deltaTime * moveSpeed);
            //move_object = true;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            
            //Destroy(gameObject.GetComponent<SkyObjects>());

        }
        else if (transform.position == ogg_interact_pos.position)
        {
            if (Active_navicella == false)
            {


                //Active_navicella = true;

                //tralation = true;
            }
        }
        
    }

    public void AudioJoystick()
    {
        FindObjectOfType<AudioManager>().Play("Joystick");
    }
}
