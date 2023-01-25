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
    private float sprintTimer;
    
    

    void Start()
    {
        //if (Input.GetMouseButtonDown(1))
        cam = GameObject.Find("Main Camera");

        sprintTimer = maxSprint;
        
        myRigidbody = GetComponent<Rigidbody>();

        //Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }

        if (Input.GetKey(KeyCode.LeftShift) && sprintTimer > 0.0f)
        {
            maxSpeed = sprintSpeed;
            sprintTimer = sprintTimer - Time.deltaTime;
        }
        else
        {
            maxSpeed = normalSpeed;
            if (Input.GetKey(KeyCode.LeftShift) == false)
            {
                sprintTimer = sprintTimer + Time.deltaTime;
            }
        }

        sprintTimer = Mathf.Clamp(sprintTimer, 0.0f, maxSprint);

        //transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed) + transform.right * Input.GetAxis("Horizontal") * maxSpeed;

        Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxSpeed + transform.right * Input.GetAxis("Horizontal") * maxSpeed);
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        //if (Input.GetMouseButtonDown(1))
        //{
            rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

            camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;

            camRotation = Mathf.Clamp(camRotation, -40.0f, 40.0f);

            cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
        //}
            
    }
    //Add SFX when picking up collectable 
}
