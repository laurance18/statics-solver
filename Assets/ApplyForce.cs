using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public float forceMagnitude; // Set this in the Inspector or via script

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ApplyForceToRigidbody(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ApplyForceToRigidbody(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ApplyForceToRigidbody(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ApplyForceToRigidbody(Vector2.right);
        }
    }

    void ApplyForceToRigidbody(Vector2 direction)
    {
        if (rb != null)
        {
            rb.AddForce(direction * forceMagnitude, ForceMode2D.Impulse);
        }
    }
}
