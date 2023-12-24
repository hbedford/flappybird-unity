using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    [SerializeField]
    private float timeToGenerateEasy = 5;
    [SerializeField]
    private float timeToGenerateHard = 0.5f;
    private float currentTime = 0;
    [SerializeField]
    private GameObject Obstacle;
    private LevelController LevelController;

    private void Awake()
    {
        currentTime = timeToGenerateEasy;
    }

    private void Start()
    {
        LevelController = GameObject.FindObjectOfType<LevelController>();
    }
    void Update()
    {
        currentTime-= Time.deltaTime;
        if(currentTime <= 0)
        {
            currentTime = Mathf.Lerp(timeToGenerateEasy, timeToGenerateHard, LevelController.Level) ;
            Generate();
        }
    }

    private void Generate()
    {
        GameObject.Instantiate(Obstacle, transform.position, Quaternion.identity);
        
    }
}
