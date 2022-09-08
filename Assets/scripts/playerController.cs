using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 0f;
    private Rigidbody rb;
    Vector2 movementVector;
    private int score = 0;
    public TextMeshProUGUI scoreCount;
    public GameObject winText;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 12)
        {
            winText.SetActive(true);
        }
    }

    void OnMove(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(movementVector.x,0f,movementVector.y) * moveSpeed);
    }

    void OnTriggerEnter(Collider pickup)
    {
        if (pickup.tag == "pickup")
        {
            pickup.gameObject.SetActive(false);
            score++;
            scoreCount.text = "Score: " + score.ToString();
        }
    }
}
