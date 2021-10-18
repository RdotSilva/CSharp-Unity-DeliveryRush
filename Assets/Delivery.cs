using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(217, 19, 19, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (216, 224, 3, 255);
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    [SerializeField] GameObject package;
    [SerializeField] GameObject customer;

    SpriteRenderer spriteRenderer;
    Score score;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        score = GetComponent<Score>();
        SpawnObject(package);
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
            hasPackage = true;

            // Change car color on package pickup
            spriteRenderer.color = hasPackageColor;
            
            // Destroy package on pickup
            Destroy(other.gameObject, destroyDelay);

            SpawnObject(customer);
        }

        if (other.tag == "Customer" && hasPackage) 
        {
            hasPackage = false;

            // Change car color on package pickup
            spriteRenderer.color = noPackageColor;

            // Update score on delivery
            score.IncrementScore();

            TimeLeft.timeLeft += 10f;

            // Destroy customer delivery spawn
            Destroy(other.gameObject, destroyDelay);

            SpawnObject(package);
        }
    }

    // Spawn a game object at a random position within range of the current camera view
    private void SpawnObject(GameObject objectToSpawn)
    {
        bool objectSpawned = false;
        while (!objectSpawned)
        {
            Vector3 objectPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4, 4f), 0f);
            if ((objectPosition - transform.position).magnitude < 3) 
            {
                continue;
            }
            else
            {
                Instantiate(objectToSpawn, objectPosition, Quaternion.identity);
                objectSpawned = true;
            }
        }
    }
}
