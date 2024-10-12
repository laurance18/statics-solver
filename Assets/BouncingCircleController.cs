using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingCircleController : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Rigidbody2D>(out rb))
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }

        // Set the linear and angular drag to simulate damping
        rb.drag = 0.5f; // Adjust as needed
        rb.angularDrag = 0.5f; // Adjust as needed

        // Ensure the Rigidbody2D has gravity enabled
        rb.gravityScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Gravity and damping are automatically applied by the Rigidbody2D component
    }
}
