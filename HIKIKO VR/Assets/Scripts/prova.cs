using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
    public Animator anim;
    public GameObject porta;
    public Animator anim_Go;
    public Material bianco;
    //private bool Time_togo;
    private Color color;
    private float Time_togo;
    private bool Time_togo_bool = false;

    public bool open_Door = false;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Appare_porta");
        Color color = bianco.color;
        color.a = 0f;
        bianco.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)|| (porta.transform.transform.eulerAngles.y < 90 && porta.transform.transform.eulerAngles.y > 80))
        {
           
            open_Door = true;

            
        }
       
        if (open_Door == true && Time_togo < 5f)
        {
            ActiveLightInRoom();
            
        }

        if (Time_togo_bool == true)
        {
            Time_togo += Time.deltaTime;
            Debug.Log(Time_togo);
        }


        if (Time_togo >= 5f)
        {
            anim_Go.SetTrigger("Go");
        }
    }
    public void ActiveGo()
    {
        anim_Go.SetTrigger("Go");
        //activeLight = 1;
    }
    public void ActiveLightInRoom()
    {
       
         color.a += 1f * Time.deltaTime;
        bianco.color = color;
        Time_togo_bool = true;
        //anim.SetTrigger("ActiveInRoom");
        //activeLight = 2;
    }
}
