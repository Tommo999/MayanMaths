using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHolder : MonoBehaviour
{
    public int HolderValue;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BallValue>())
        {
            HolderValue += other.GetComponent<BallValue>().BallNumberValue;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BallValue>())
        {
            HolderValue -= other.GetComponent<BallValue>().BallNumberValue;
        }
    }
}
