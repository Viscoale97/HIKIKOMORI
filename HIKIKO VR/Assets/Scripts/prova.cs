using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
    public Animator anim;
    public GameObject porta;
    public Animator anim_Go;

    public bool open_Door = false;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Appare_porta");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)|| porta.transform.transform.eulerAngles.y > 90f)
        {
           
            open_Door = true;
            
            anim.SetTrigger("Active");
        }
    }
    public void ActiveGo()
    {
        anim_Go.SetTrigger("Go");
        //activeLight = 1;
    }
    public void ActiveLightInRoom()
    {
        anim.SetTrigger("ActiveInRoom");
        //activeLight = 2;
    }
}
