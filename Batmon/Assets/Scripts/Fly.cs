using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Orange")
        {
            Destroy(collision.gameObject);
            gameManager.addPoints(10);
        }
        else if (collision.gameObject.tag == "Boundary")
        {
            gameManager.GameOver();
        }
        else
        {
            Debug.Log("Collsion unhandled at: " + collision.gameObject.name + " With tag: " + collision.gameObject.tag );
        }
    }
}
