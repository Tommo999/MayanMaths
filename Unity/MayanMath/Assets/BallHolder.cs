using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHolder : MonoBehaviour
{
    public int HolderValue;
    public EquationManager EM;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BallValue>())
        {
            HolderValue += other.GetComponent<BallValue>().BallNumberValue;
            EM.UpdateValue();

            foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
            {
                renderer.material = other.GetComponent<BallValue>().NumberedMaterials[HolderValue];
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BallValue>())
        {
            HolderValue -= other.GetComponent<BallValue>().BallNumberValue;
            EM.UpdateValue();

            foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
            {
                renderer.material = other.GetComponent<BallValue>().NumberedMaterials[HolderValue];
            }
        }
    }
}
