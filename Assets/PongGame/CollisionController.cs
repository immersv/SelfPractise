using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreManager scoreManager;
    public AudioController audioController;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Bounce(Collision2D coll)
    {
        
        Vector3 ballPostion = transform.position;
        Vector3 racketPostion = coll.transform.position;
        float racketHeight = GetComponent<Collider2D>().bounds.size.y;
        float x;
        if (coll.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y=(ballPostion.y-racketPostion.y)/racketHeight;
        ballMovement.IncrementBallSpeed();
        ballMovement.BallMove(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            audioController.PlayAudio("RacketAudio");
            Bounce(collision);
           
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("collision with wall left");
            audioController.PlayAudio("WallAudio");
            scoreManager.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("collision with wall Right");
            audioController.PlayAudio("WallAudio");
            scoreManager.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}
