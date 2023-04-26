using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOrDeactivate : MonoBehaviour
{
    public bool isTriggered = true;
    public GameObject gameObject;

    [SerializeField] GameObject _dialogueParent;
    [SerializeField] GameObject _dialogue; 
  //  [SerializeField]  chase;
    

    private void OnTriggerEnter(Collider other)
    {
        if (isTriggered)
        {
            if (other.tag == "Player")
            {
                TriggerObject();
            }
        }
    }
    
    
    private void TriggerObject()
    {   
       gameObject.SetActive(true);
    }
}
