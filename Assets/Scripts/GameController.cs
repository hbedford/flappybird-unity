using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOver;
    private Plane Plane;

    private void Start()
    {
        Plane = GameObject.FindObjectOfType<Plane>();
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
    }

    private void DestroyObstacles()
    {
        ObstacleController[] obstacles = GameObject.FindObjectsOfType<ObstacleController>();
        foreach (ObstacleController obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }
    }
}
