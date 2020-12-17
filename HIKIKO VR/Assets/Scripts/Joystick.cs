using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    private float speed = 0.1f;
    public ParticleSystem particle;
    private bool asteroidi;
    public GameObject navicella;
    public Transform navicellaTarget;
    public Vector3 pos;
    public bool active_Timer;
    private float Timer = 0f;
    public bool disactive_joystick = false;
    private float Emissioner = 0f;
    // Start is called before the first frame update
    void Start()
    {
        particle.Pause();
        //emission = particle.emission.rateOverTime;
    }

    // Update is called once per frame
    void Update()
    {
        var emission = particle.emission;

        if(gameObject.GetComponent<SkyObjects>().trigger == false)
        {
            
            if (gameObject.transform.localScale.x <= 2f)
            {
                gameObject.transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime * speed;
                
            }
        }

        if (gameObject.GetComponent<interactableObjMove>().fatto == true)
        {
            //gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward);
            particle.Play();
            gameObject.GetComponent<deployAsteroid>().enabled = true;
            gameObject.GetComponent<Rotate>().enabled = false;
           //if (gameObject.transform.position.z <= 37f)
            {
                navicella.SetActive(true);

            }
            
        }

        if (navicella.GetComponent<Navicella>().Active_navicella == false)
        {
            navicellaTarget.transform.position = transform.TransformPoint(pos);
            //navicellaTarget.transform.position.Set(transform.position.x, transform.position.y + 5f, transform.position.z + 5f);
            //navicella.transform.position = navicellaTarget.transform.position;

        }

        if (active_Timer == true)
        {
            Timer += Time.deltaTime;
            if (Timer > 30f)
            {
                disactive_joystick = true;
            }
        }

        if (disactive_joystick == true)
        {
            emission.rateOverTime = Emissioner;
            //gameObject.GetComponent<deployAsteroid>().enabled = false;
        }
        
    }

    public void ActiveNavivella()
    {
        particle.Play();
        gameObject.GetComponent<deployAsteroid>().enabled = true;
        gameObject.GetComponent<Rotate>().enabled = false;
        active_Timer = true;
        //if (gameObject.transform.position.z <= 37f)
        {
            navicella.SetActive(true);

        }
    }
}
