using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navicella : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 ogg_interact_pos = new Vector3(0, 1.30f, 1.10f);
    public bool fatto = false;
    private float moveSpeed = 10f;
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

        if (transform.position != ogg_interact_pos && fatto == false)
        {

            transform.position = Vector3.MoveTowards(transform.position, ogg_interact_pos, Time.deltaTime * moveSpeed);
            //move_object = true;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            
            //Destroy(gameObject.GetComponent<SkyObjects>());

        }
        else if (transform.position == ogg_interact_pos)
        {
            if (fatto == false)
            {
                fatto = true;

                //tralation = true;
            }
        }
    }
}
