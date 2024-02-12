using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float movementX;
    [SerializeField] private float movementY;
    [SerializeField] Vector2 movementVector = Vector2.zero;
    [SerializeField] Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        movement = new Vector3(movementX, 0.0f, movementY);
            rb.AddForce(movement);
    }

    void OnMove(InputValue movementValue) 
    {
        //
        movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}
