using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Basket : MonoBehaviour
{
    private bool lancio = false;
    private float temposcad = 0f;
    private Vector3 ogg_interact_pos = new Vector3(0, 0.7f, 0.4f);
    private bool endInteraction = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<XRGrab>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lancio == true)
        {
            temposcad += Time.deltaTime;
            Debug.Log(temposcad);
        }
        
        if (temposcad > 5f)
        {
            gameObject.GetComponent<interactableObjMove>().enabled = true;
            //gameObject.GetComponent<SkyObjects>().enabled = true;
            temposcad = 0f;
            lancio = false;
            gameObject.GetComponent<TestBasket>().enabled = false;
            endInteraction = true;
            
        }

        if (gameObject.GetComponent<interactableObjMove>().enabled == false && endInteraction == true)
        {
            endInteraction = false;
            gameObject.GetComponent<SkyObjects>().enabled = true;
            gameObject.GetComponent<SkyObjects>().move_object = false;
            gameObject.GetComponent<SkyObjects>().trigger = true;
            Debug.Log("Palla entrata");
        }
    }
    public void Gravity()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
    public void Lancio()
    {
        lancio = true;
        gameObject.GetComponent<XRGrab>().enabled = false;
    }
}
