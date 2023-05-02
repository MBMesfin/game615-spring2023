using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    BoxCollider2D box;

    LayerMask mask;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W) && onIce_Ground()) 
        {
            rb.AddForce(Vector2.up * 500);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            rb.AddForce(Vector2.up * 500);
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(transform.forward * 500);
        }

        float hAxis = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(10* hAxis, rb.velocity.y);

    }

    bool onIce_Ground()
    {
        RaycastHit2D hit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0.1f, Vector2.down, 1, mask);
        return hit.collider != null;
    }

    
}
