using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float sideWaySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);//will add force to player movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideWaySpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideWaySpeed * Time.deltaTime, 0, 0);
        }
    }
}
