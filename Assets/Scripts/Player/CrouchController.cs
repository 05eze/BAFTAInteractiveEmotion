using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchController : MonoBehaviour
{

    public Transform crouchPos;
    public Transform crouchOriginalPos;
    public Camera cam;
    public CharacterController Con;
    public Transform capsule;
    public float conHeight = 1f;
    public float CapsuleHeight = .5f;
    public float crouchSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            //Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * crouchSpeed + transform.right * Input.GetAxis("Horizontal") * crouchSpeed);

            cam.transform.position = crouchPos.transform.position;
            Con.height = conHeight;
            capsule.localScale = new Vector3(1, CapsuleHeight, 1);
        }
        else
        {
            cam.transform.position = crouchOriginalPos.transform.position;
            Con.height = 2f;
            capsule.localScale = new Vector3(1, 1, 1);
        }
    } //https://www.youtube.com/watch?v=A-LMxuj-A0I 9:02
}
