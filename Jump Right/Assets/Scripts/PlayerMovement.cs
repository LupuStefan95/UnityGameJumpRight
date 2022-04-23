using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //playerInput = GetComponent<PlayerInput>(); Can be binded a specific metod in the Player Input inspector.
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
        float speed = 15f;
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed , ForceMode.Force);

    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (transform.position.y < 3f)
        {
            if (context.performed)
            {
                Debug.Log(context);
                rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
   


}


