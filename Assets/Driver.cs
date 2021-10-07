using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the car
        transform.Rotate(0, 0, 0.1f);
        // Drive in the direction the car is facing
        transform.Translate(0, 0.01f, 0);
    }
}
