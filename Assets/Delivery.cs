using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        // TODO: Add logic to remove user life on collision
        Debug.Log("Collision detected");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Add logic to add user life when power up is collected
        
        // Logic for when a user collects a package
        if (other.tag == "Package") 
        {
            Debug.Log("Package collected!");
            hasPackage = true;
        }

        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}
