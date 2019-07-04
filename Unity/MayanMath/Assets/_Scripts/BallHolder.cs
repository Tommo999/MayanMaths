using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHolder : MonoBehaviour
{
    public int HolderValue;
    public EquationManager EM;
    public Renderer DisplayPanel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BallValue>())
        {
            HolderValue += other.GetComponent<BallValue>().BallNumberValue;
            EM.UpdateValue();
            DisplayPanel.material = other.GetComponent<BallValue>().NumberedMaterials[HolderValue];
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BallValue>())
        {
            HolderValue -= other.GetComponent<BallValue>().BallNumberValue;
            EM.UpdateValue();
            DisplayPanel.material = other.GetComponent<BallValue>().NumberedMaterials[HolderValue];
        }
    }
}