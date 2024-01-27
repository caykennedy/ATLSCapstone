using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    // private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    public Transform orientation; 

    float horizontalInput; 
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody capsule;

    // Start is called before the first frame update
    private void Start()
    {

        capsule = GetComponent<Rigidbody>(); 
        capsule.freezeRotation = true; 

        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {

        PlayerInput();
    }

    private void FixedUpdate() 
    {
        PlayerMovement();
    }

    private void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); 
        verticalInput = Input.GetAxisRaw("vertical");
    }

    private void PlayerMovement()
    {
        // getting movement in the direction you're looking
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        capsule.AddForce(moveDirection.normalized * playerSpeed * 10f, ForceMode.Force);
    }
}
