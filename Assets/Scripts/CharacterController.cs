using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
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
    

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }   

        //transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed) + transform.right * Input.GetAxis("Horizontal") * maxSpeed;

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed + transform.right * Input.GetAxis("Horizontal") * maxSpeed;
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3( camRotation, 0.0f, 0.0f));
    }
}
