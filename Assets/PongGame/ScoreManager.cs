using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    int scorePlayer1 = 0;
    int scorePlayer2 = 0;
    public Text player1Score,player2Score;
    public int goalToWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Score.text = scorePlayer1.ToString();
        player2Score.text = scorePlayer2.ToString();
        if (scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            Debug.Log("You Won the Game");
            SceneManager.LoadScene(2);

        }

    }
   public void GoalPlayer1()
    {
        scorePlayer1++;
    }
   public void GoalPlayer2()
    {
        scorePlayer2++;
    }
}
