using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject joystick;
    public GameObject palla;
    private int counter; 
    private int counter_J;
    private int counter_P;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter = counter_J + counter_P;
        
        
        
        
        if (counter == 2)
        {

        }
        
    }
}
