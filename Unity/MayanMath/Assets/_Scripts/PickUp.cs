using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Hand;
    public float ThrowPower;

    [SerializeField] GameObject CurrentObject;
    [SerializeField] bool HoldingObject;

    void Update()
    {
        if (CurrentObject != null && (Input.GetButtonDown("PickUp")))
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
        if (CurrentObject != null && (Input.GetButtonDown("Throw")))
        {
            if (HoldingObject)
            {
                HoldingObject = false;
                CurrentObject.GetComponent<Rigidbody>().isKinematic = false;
                CurrentObject.transform.SetParent(null);
                CurrentObject.transform.SetPositionAndRotation(transform.position, transform.rotation);

                CurrentObject.GetComponent<Rigidbody>().AddForce(transform.forward * ThrowPower);
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