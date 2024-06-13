using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   public float moveSpeed;
   public Rigidbody2D rb;
   // BoxCollider2D bc;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
       // bc.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // rb.velocity = new Vector2(moveSpeed * Mathf.Sign(rb.velocity.x), 0f);
        if (facingRight())
        {
            rb.velocity = new Vector2(moveSpeed, 0f);

        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, 0f);


        }

    }
    private bool facingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;


    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        //flip sprite
        transform.localScale = new Vector2(2f, transform.localScale.y);
        
    }
}
