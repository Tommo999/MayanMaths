using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    [SerializeField] GameObject[] DiscoPlatformRed; //0
    [SerializeField] GameObject[] DiscoPlatformBlue; //1
    [SerializeField] GameObject[] DiscoPlatformGreen; //2
    [SerializeField] GameObject[] DiscoPlatformYellow; //3
    // Update is called once per frame

    void Update()
    {
        switch (Mathf.Floor(Time.time % 4))
        {
            case 0:
                foreach (GameObject Plat in DiscoPlatformRed)
                {
                    Plat.SetActive(true);
                }
                foreach (GameObject Plat in DiscoPlatformBlue)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformGreen)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformYellow)
                {
                    Plat.SetActive(false);
                }
                break;
            case 1:
                foreach (GameObject Plat in DiscoPlatformRed)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformBlue)
                {
                    Plat.SetActive(true);
                }
                foreach (GameObject Plat in DiscoPlatformGreen)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformYellow)
                {
                    Plat.SetActive(false);
                }
                break;
            case 2:
                foreach (GameObject Plat in DiscoPlatformRed)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformBlue)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformGreen)
                {
                    Plat.SetActive(true);
                }
                foreach (GameObject Plat in DiscoPlatformYellow)
                {
                    Plat.SetActive(false);
                }
                break;
            case 3:
                foreach (GameObject Plat in DiscoPlatformRed)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformBlue)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformGreen)
                {
                    Plat.SetActive(false);
                }
                foreach (GameObject Plat in DiscoPlatformYellow)
                {
                    Plat.SetActive(true);
                }
                break;
        }
    }
}