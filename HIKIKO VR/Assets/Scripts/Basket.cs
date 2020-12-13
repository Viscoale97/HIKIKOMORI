using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Basket : MonoBehaviour
{
    private bool lancio = false;
    private float temposcad = 0f;
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
        }
        
        if (temposcad > 80f)
        {
            gameObject.GetComponent<interactableObjMove>().enabled = true;
            temposcad = 0f;
            lancio = false;

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
