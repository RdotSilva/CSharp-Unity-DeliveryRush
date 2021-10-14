using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(217, 19, 19, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (216, 224, 3, 255);
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // TODO: Add logic to remove user life on collision
        Debug.Log("Collision detected");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Add logic to add user life when power up is collected
        
        // Logic for when a user collects a package
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Package collected!");
            hasPackage = true;

            // Change car color on package pickup
            spriteRenderer.color = hasPackageColor;
            
            // Destroy package on pickup
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            // Change car color on package pickup
            spriteRenderer.color = noPackageColor;
        }
    }
}
