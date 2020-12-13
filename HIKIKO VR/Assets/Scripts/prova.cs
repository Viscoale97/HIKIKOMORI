using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova : MonoBehaviour
{
    public Animator anim;
    public GameObject porta;
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
            anim.SetTrigger("Go");
        }
    }
}
