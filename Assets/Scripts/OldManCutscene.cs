using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManCutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(5);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}