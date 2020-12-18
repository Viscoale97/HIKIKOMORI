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
    public enum ElementState { Start, Medio, End }
    public ElementState currentState = ElementState.Start;
    public LayerMask mask_not;
    public LayerMask mask_eve;
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
            currentState = ElementState.Start;


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
            emission.rateOverTime = Emissioner + 138f;
            if (Timer > 30f)
            {
                disactive_joystick = true;
                active_Timer = false;
                Timer = 0f;
            }
        }

        if (disactive_joystick == true && currentState == ElementState.Medio)
        {
            
            emission.rateOverTime = Emissioner;
            currentState = ElementState.End;
            gameObject.GetComponent<XRGrab>().interactionLayerMask = mask_not;
            //gameObject.GetComponent<deployAsteroid>().enabled = false;
        }

        if (navicella.GetComponent<Navicella>().disattivo == true || currentState == ElementState.Start)
        {
            gameObject.GetComponent<SkyObjects>().enabled = true;
            gameObject.GetComponent<SkyObjects>().move_object = false;
            gameObject.GetComponent<SkyObjects>().trigger = true;
            //currentState = ElementState.Start;
            disactive_joystick = false;
            gameObject.GetComponent<XRGrab>().interactionLayerMask = mask_eve;
        }
        else if (navicella.GetComponent<Navicella>().disattivo == false)
        {
            gameObject.GetComponent<SkyObjects>().enabled = false;
        }

       /* if (currentState == ElementState.End)
        {
            //gameObject.GetComponent<XRGrab>().interactionLayerMask = mask_not;
        }
        else if (gameObject.GetComponent<SkyObjects>().trigger == false && currentState == ElementState.Start)
        {
            
        }*/
        
    }

    public void ActiveNavivella()
    {
        particle.Play();
        currentState = ElementState.Medio;
        gameObject.GetComponent<deployAsteroid>().enabled = true;
        gameObject.GetComponent<Rotate>().enabled = false;
        active_Timer = true;
        
        
        //if (gameObject.transform.position.z <= 37f)
        {
            navicella.SetActive(true);

        }
    }
}
