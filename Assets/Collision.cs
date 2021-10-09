using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        // TODO: Add logic to remove user life on collision
        Debug.Log("Collision detected");
    }
}
