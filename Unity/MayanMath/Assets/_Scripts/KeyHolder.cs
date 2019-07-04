using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public bool Keytected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KeyBall>())
        {
            Keytected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<KeyBall>())
        {
            Keytected = false;
        }
    }
}
