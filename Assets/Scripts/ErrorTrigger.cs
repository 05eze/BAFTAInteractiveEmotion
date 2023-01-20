using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ErrorTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene("ErrorScreen");
        }

    // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
