using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // Allow a user to steer the car
        transform.Rotate(0, 0, -steerAmount);
        // Drive in the direction the car is facing
        transform.Translate(0, moveAmount, 0);
    }

    // TODO: Add collision detection logic
}
