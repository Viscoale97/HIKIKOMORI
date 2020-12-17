using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBasket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            gameObject.transform.position = new Vector3(0f, 1f, 15f);
            gameObject.GetComponent<Basket>().Gravity();
            gameObject.GetComponent<Basket>().Lancio();
            gameObject.GetComponent<SkyObjects>().MoveToPlayer();
        }
        
    }
}
