using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject driverToFollow;

    void LateUpdate()
    {
        // Ensure the camera follows the driver vehicle
        transform.position = driverToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
