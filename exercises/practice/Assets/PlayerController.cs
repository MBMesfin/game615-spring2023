using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

  // float moveS = 5f;

    //float 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            //gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveS * hAxis);
            //gameObject.transform.Rotate(gameObject.transform.forward * Time.deltaTime * moveS * vAxis);
            gameObject.transform.Translate(gameObject.transform.forward);
        }

    }
}
