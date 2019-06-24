using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    Rigidbody OtherRB;
    public float JumpPower;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>())
        {
            OtherRB = other.GetComponent<Rigidbody>();
            OtherRB.AddForce(Vector3.up * JumpPower);
            Debug.Log("Jump");
        }
    }
}
