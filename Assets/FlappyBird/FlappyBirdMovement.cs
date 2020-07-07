using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdMovement : MonoBehaviour
{   [SerializeField]
    float birdForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool _fireButtonPressed = Input.GetButton("Fire1");
        Debug.Log("Button to press");
        if (_fireButtonPressed)
        {
            Debug.Log("Button pressed");
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * birdForce);
        }
    }
}
