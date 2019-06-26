using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PressureScript : MonoBehaviour
{
    public static bool isTriggered; 

    // Start is called before the first frame update
    void Start()
    {
        if (isTriggered == true)
        {
            //GetComponent<Animation>().Play("PressureDown");

        }
        if (isTriggered == false)
        {
            //GetComponent<Animation>().Play("PressureUp");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Pressure down");

        if (collision.gameObject.GetComponent<Rigidbody>())
        {
            isTriggered = true;
            Debug.Log("Pressure down");
        }        
    }

    private void OnTriggerExit(Collider collision)
    {
        isTriggered = false;
        Debug.Log("Pressure up");
    }
}