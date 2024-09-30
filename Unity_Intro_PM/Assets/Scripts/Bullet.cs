using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Add logic for what happens when the bullet hits something
        Destroy(gameObject); // Destroy bullet on impact
    }

    private void Start()
    {
        Destroy(gameObject, 5f); // Destroy bullet after 5 seconds to prevent clutter
    }
}
