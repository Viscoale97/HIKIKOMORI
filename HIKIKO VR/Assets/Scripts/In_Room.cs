using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Room : MonoBehaviour
{
    public GameObject image;
    private Animator Anim_Image;
    public GameObject XRrig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<prova>().open_Door == true)
        {
            XRrig.transform.position = new Vector3(0, 0, 0);
            //Anim_Image.SetTrigger("ActiveInRoom");
        }
    }
}
