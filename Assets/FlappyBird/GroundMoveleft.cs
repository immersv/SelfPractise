using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoveleft : MonoBehaviour
{
    [SerializeField]
    private float groundSpeed;// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * groundSpeed);
        if (transform.position.x < -2)
        {
           
            transform.position = new Vector3(6, -8.5f, 0);
        }
    }
}
