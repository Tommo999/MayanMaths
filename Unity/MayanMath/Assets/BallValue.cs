using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallValue : MonoBehaviour
{
    public int BallNumberValue;

    public Material[] NumberedMaterials = new Material[9];

    private void FixedUpdate()
    {
        gameObject.GetComponent<Renderer>().material = NumberedMaterials[BallNumberValue];
    }
}
