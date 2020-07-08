using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed,increamentSpeed,maxSpeed;
    int hitCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartBall());
    }
    public IEnumerator StartBall(bool isplayer1=true)
    {
        hitCounter = 0;
        yield return new WaitForSeconds(2f);
        if (isplayer1)
        {
            BallMove(new Vector2(-1, 0));
        }
        else
        {
            BallMove(new Vector2(1, 0));
        }


    }

   public void BallMove(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = movementSpeed + hitCounter * increamentSpeed;
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = dir * speed;

    }
    public void IncrementBallSpeed()
    {
        if (hitCounter * increamentSpeed <= maxSpeed)
        {
            hitCounter++;

        }
    }
}
