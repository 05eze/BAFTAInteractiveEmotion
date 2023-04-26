using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject gObject;
    public ChaseCharacter chaseCharacter;
    public CharacterController characterController;

    void Start()
    {
        chaseCharacter = thePlayer.GetComponent<ChaseCharacter>();
        characterController = thePlayer.GetComponent<CharacterController>();
    }
    



    




    void OnTriggerEnter(Collider other)
    {
        cutsceneCam.SetActive(true);
        gObject.SetActive(true);
       
       
        chaseCharacter.enabled = !chaseCharacter.enabled;
        characterController.enabled = !characterController.enabled;
        

        //thePlayer.GetComponent<ChaseCharacter>().SetActive(true);
       // thePlayer.GetComponent<CharacterController>().SetActive(false);

    }

    

}
