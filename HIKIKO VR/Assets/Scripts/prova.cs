using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
    public Animator anim;
    public GameObject porta;
    public GameObject image;
    private Animator Anim_Image;
    public bool open_Door = false;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Appare_porta");
        Anim_Image = image.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)|| porta.transform.transform.eulerAngles.y > 90f)
        {
            Anim_Image.SetTrigger("Active");
            open_Door = true;
            anim.SetTrigger("End");
        }
    }
}
