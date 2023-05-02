using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0.001f;
    public float launchForce;

    float rotateSpeed = .2f;

    float lastRotateDirectionTime = .001f;
    public Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastRotateDirectionTime > 1f)
        {
            rotateSpeed = rotateSpeed * -1;
            lastRotateDirectionTime = Time.time;
        }

        gameObject.transform.Rotate(0, rotateSpeed, 0);
        if (Input.GetKey(KeyCode.Space)) {

            //gameObject.transform.Translate(gameObject.transform.forward * speed);
            rb.useGravity = true;
            rb.AddForce(gameObject.transform.forward * launchForce);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;


           
        }
    }
}
