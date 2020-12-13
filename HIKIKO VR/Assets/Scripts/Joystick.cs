using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    private float speed = 0.1f;
    public ParticleSystem particle;
    private bool asteroidi;
    public GameObject navicella;
    // Start is called before the first frame update
    void Start()
    {
        particle.Pause();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<SkyObjects>().trigger == false)
        {
            
            if (gameObject.transform.localScale.x <= 2f)
            {
                gameObject.transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime * speed;
                
            }
        }

        if (gameObject.GetComponent<interactableObjMove>().fatto == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward);
            particle.Play();
            gameObject.GetComponent<deployAsteroid>().enabled = true;
            if (gameObject.transform.position.z <= 37f)
            {
                navicella.SetActive(true);

            }
            
        }

        
    }
}
