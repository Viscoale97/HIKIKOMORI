using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navicella : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z >= 4f)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-(Vector3.forward));
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }
        
    }
}
