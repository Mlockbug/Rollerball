using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 0f;
    private Rigidbody rb;
    Vector2 movementVector;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(movementVector.x,0f,movementVector.y) * moveSpeed);
    }
}
