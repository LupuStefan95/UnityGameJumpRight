using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    //private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;
    private bool isGrounded = true;
    public SpawnManager spawnManager;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //playerInput = GetComponent<PlayerInput>(); Can be binded a specific method in the Player Input inspector.
        playerInputActions = new PlayerInputActions();
        playerInputActions.Movements.Enable();
        playerInputActions.Movements.Jump.performed += Jump;
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Movements.Move.ReadValue<Vector2>();
        float topSpeed = 7f;
        if (rb.velocity.magnitude < topSpeed)
        {
            rb.AddForce(500f * Time.deltaTime * new Vector3(inputVector.x, 0, inputVector.y));
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
       
        if (context.performed && isGrounded && (rb.transform.position.y > 2.48f))
        {
                Debug.Log(context);
                rb.AddForce(Vector3.up * 6f, ForceMode.Impulse);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }





}


