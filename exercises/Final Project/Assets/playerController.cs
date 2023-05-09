using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D box;
    public LayerMask mask;
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public int score;
    public float TimeLeft;
    public bool TimerOn = false;

    // float moveSpeed = 1f;




    //  CoinManager cm;
    //CoinScript cs;

    public int coinCount;
   public TMP_Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
        TimerOn = true;
        TimeLeft = 60;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && OnGround())
        {
            rb.AddForce(Vector2.up * 300); 
        }

        if (Input.GetKeyDown(KeyCode.W) && rb.velocity.y > 0)   
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);

        }
        //if (Input.GetKeyDown(KeyCode.D) && rb.velocity.x > 0)
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, 0);


        //}



        float hAxis = Input.GetAxis("Horizontal");
       // float vAxis = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(10 * hAxis, rb.velocity.y);
        // rb.velocity = new Vector2(10 * vAxis, rb.velocity.x);

        if (TimerOn)
        {
            if (TimeLeft > 0 && coinCount < 13)
            {
                TimeLeft -= Time.deltaTime;
                timerText.text = TimeLeft.ToString();
            }
            else if (TimeLeft > 0 && coinCount == 13)
            {
                scoreText.text = "You Win!";
            }
            else
            {
                TimeLeft = 0;
                timerText.text = TimeLeft.ToString();
                TimerOn = false;
                scoreText.text = "You lose! ";

            }
        }


    }
    bool OnGround()
    {
       RaycastHit2D hit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0, Vector2.down, 1, mask);
       

        
        return hit.collider != null;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            //cs.coinCount++;
            coinCount++;
            coinText.text = "Coin Counter: " + coinCount.ToString();
            Destroy(other.gameObject);
           
        }
    }

 
    


}
