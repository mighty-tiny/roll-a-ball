using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject ufo;
    [SerializeField] private GameObject beam;
    [SerializeField] private float speed;
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
            rb.AddForce(movement * speed);
    }

    void OnMove(InputValue movementValue) 
    {
        //
        movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pickup")
        {
            other.gameObject.SetActive(false);
        } 
    }
}
