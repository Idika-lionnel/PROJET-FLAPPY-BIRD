using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager; // Added GameManager reference
    public float velocity = 2.4f;
    public bool isDead = false; // Added isDead variable
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead) // Only allow jumping if not dead
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody.velocity = Vector2.up * velocity;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead) // Check if not already dead
        {
            isDead = true;
            gameManager.GameOver();
        }
    }
}
