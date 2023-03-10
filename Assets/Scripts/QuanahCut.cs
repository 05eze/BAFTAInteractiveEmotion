using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuanahCut : MonoBehaviour
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
        yield return new WaitForSeconds(20);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
