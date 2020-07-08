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
        ResetBallPosition(isplayer1);
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
    private void ResetBallPosition(bool isplayer1)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isplayer1)
        {
            gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }
}
