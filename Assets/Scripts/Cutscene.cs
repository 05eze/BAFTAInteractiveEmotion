using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject gObject;

    void OnTriggerEnter(Collider other)
    {
        cutsceneCam.SetActive(true);
        gObject.SetActive(true);
        thePlayer.SetActive(false);
    }

}
