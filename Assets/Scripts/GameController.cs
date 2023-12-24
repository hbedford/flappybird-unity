using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOver;
    private Plane Plane;
    private int score;
    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private Text maxScoreText;
    private int maxScore;
    [SerializeField]
    private Image positionCoin;
    [SerializeField]
    private Sprite[] coins;


    private void Start()
    {
        Plane = GameObject.FindObjectOfType<Plane>();
        score = 0;

    }

   public void EndGame()
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
        SaveScore();

    }

    public void RestartGame()
    {
        GameOver.SetActive(false);
        Time.timeScale = 1;
        Plane.Restart();
        DestroyObstacles();
        score = 0;
        ScoreText.text = score.ToString();
    }

    private void DestroyObstacles()
    {
        ObstacleController[] obstacles = GameObject.FindObjectsOfType<ObstacleController>();
        foreach (ObstacleController obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }
    }
    public void AddScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void SaveScore()
    {
        if (score > PlayerPrefs.GetInt("Score")) 

       {
            PlayerPrefs.SetInt("Score", score);
        }
        UpdateInterface();
    }

    public void UpdateInterface()
    {
        maxScore=  PlayerPrefs.GetInt("Score");
        maxScoreText.text = maxScore.ToString();
        VerifyCoinColor();
    }

    private void VerifyCoinColor()
    {
        if(score> maxScore - 2)
        {
            positionCoin.sprite = coins[0];
            return;
        }
        if(score > maxScore / 2)
        {
            positionCoin.sprite = coins[1];
            return;
        }
        positionCoin.sprite = coins[2];

    }
}
