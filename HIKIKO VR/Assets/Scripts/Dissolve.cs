using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    
    [SerializeField] private Renderer[] materiali = new Renderer[0];
    public bool cestino_active = false;
    public GameObject ogg;

    private float currentDissolveValue = 0f;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (ogg.GetComponent<SkyObjects>().move_object == true)
        {
            if (currentDissolveValue < 1)
            {
                currentDissolveValue += Time.deltaTime * (1 / 2f);
            }
           
        }
        else if (ogg.GetComponent<SkyObjects>().move_object == false)
        {
            currentDissolveValue = 0f;
        }
        
        

        foreach(Renderer renderer in materiali)
        {
            renderer.material.SetFloat("_appear", currentDissolveValue);
        }
    }
}
