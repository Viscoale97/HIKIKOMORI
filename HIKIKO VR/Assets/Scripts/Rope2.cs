using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Rope2 : MonoBehaviour
{
    private bool ActiveRopeBool = false;
    public GameObject hand;
    private float y;
    private float y_rope;
    private float y_rope_change;
    private bool takeOne = false;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ActiveRopeBool)
        {
            y_rope_change = y_rope - hand.transform.position.y;
            transform.position = new Vector3(transform.position.x, y_rope_change, transform.position.z);
            if ((hand.transform.position.y - y) > 0.5f)
            {
                Cube.transform.position = new Vector3(1f, 1f, 1f);
            }
        }
        else if (!ActiveRopeBool)
        {

        }
    }
    
    public void ActiveRope()
    {
        ActiveRopeBool = true;
        if (takeOne == false)
        {
            y = hand.transform.position.y;
            y_rope = transform.position.y;
        }
       
    }
    public void DeActiveRope()
    {
        ActiveRopeBool = false;
    }
}
