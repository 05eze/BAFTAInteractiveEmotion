using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float height;

    public float maxSpeed;
    public float normalSpeed = 10.0f;
    public float sprintSpeed = 20.0f;
    
    public float rotation = 0.0f;
    public float camRotation = 0.0f;
    GameObject cam;
    Rigidbody myRigidbody;


    private bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 300.0f;
    
    public float rotationSpeed = 2.0f;
    public float camRotationSpeed = -1.5f;

    public float maxSprint = 5.0f;
    public bool canMove = true;
    
    

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        
        myRigidbody = GetComponent<Rigidbody>();

        //Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {

        Debug.Log(canMove);

       if (canMove)
       {

            isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

            if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.AddForce(transform.up * jumpForce);
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                maxSpeed = sprintSpeed;


            }
            else
            {
                maxSpeed = normalSpeed;
                if (Input.GetKey(KeyCode.LeftShift) == false)
                {

                }
            }


            //Key Controls
            Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxSpeed + transform.right * Input.GetAxis("Horizontal") * maxSpeed);
            myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);


            //Player rotation
            rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

            //Cam controller
            camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
            camRotation = Mathf.Clamp(camRotation, -40.0f, 40.0f);
            cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
            
       }
    }
    //Add SFX when picking up collectable 
}
