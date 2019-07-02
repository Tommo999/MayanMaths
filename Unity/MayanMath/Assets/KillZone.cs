using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform Respawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Detected: "+ other.name);
        if(other.tag == "Player")
        {
            Debug.Log("Respawn");
            other.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
            other.transform.position = Respawn.position;
            other.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
        }
    }
}
