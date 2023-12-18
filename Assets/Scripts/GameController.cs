using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOver;
    private Plane Plane;
    private int score;
    [SerializeField]
    private TMP_Text ScoreText;

    private void Start()
    {
        Plane = GameObject.FindObjectOfType<Plane>();
        score = 0;

    }

   public void EndGame()
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);

    }

    public void RestartGame()
    {
        GameOver.SetActive(false);
        Time.timeScale = 1;
        Plane.Restart();
        DestroyObstacles();
        score = 0;
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
}
