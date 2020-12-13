using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveVoiceOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject image;
    private Animator Anim;
    private int activeLight = 0;
    public Light light1;
    public Light light2;

    void Start()
    {
        Anim = image.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeLight == 1)
        {
            light1.intensity = Time.deltaTime * 100;
            light2.intensity = Time.deltaTime * 100;
        }
        else if (activeLight == 2)
        {
            light1.intensity -= Time.deltaTime * 100;
            light2.intensity -= Time.deltaTime * 100;
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
        Anim.SetTrigger("Active");
        activeLight = 1;
    }
    public void ActiveLightInRoom()
    {
        Anim.SetTrigger("ActiveInRoom");
        activeLight = 2;
    }
}
