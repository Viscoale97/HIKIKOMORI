using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveVoiceOver : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int activeLight = 0;
    public Light light1;
    public Light light2;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (activeLight == 1)
        {
            //light1.intensity = Time.deltaTime * 100;
            //light2.intensity = Time.deltaTime * 100;
        }
        else if (activeLight == 2)
        {
            //light1.intensity -= Time.deltaTime * 100;
            //light2.intensity -= Time.deltaTime * 100;
        }
    }

    public void PlaySoundVoiceStart()
    {
        FindObjectOfType<AudioManager>().Play("Porta");
    }
    
    public void PlaySoundVoiceStanza()
    {
        FindObjectOfType<AudioManager>().Play("Stanza");
    }
    public void ActiveLight()
    {
        
        //activeLight = 1;
    }
    public void ActiveLightInRoom()
    {
       
        //activeLight = 2;
    }
}
