using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Hand;

    [SerializeField] GameObject CurrentObject;
    [SerializeField] bool HoldingObject;

    void Update()
    {
        if (CurrentObject != null && (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)))
        {
            if (!HoldingObject)
            {
                HoldingObject = true;
                CurrentObject.GetComponent<Rigidbody>().isKinematic = true;
                CurrentObject.transform.SetParent(Hand);
                CurrentObject.transform.SetPositionAndRotation(Hand.position, Hand.rotation);
            }
            else
            {
                HoldingObject = false;
                CurrentObject.GetComponent<Rigidbody>().isKinematic = false;
                CurrentObject.transform.SetParent(null);
                CurrentObject.transform.SetPositionAndRotation(transform.position, transform.rotation);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PickUp" && !HoldingObject)
        {
            CurrentObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PickUp" && !HoldingObject)
        {
            CurrentObject = null;
        }
    }
}
