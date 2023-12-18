using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour
{
    [SerializeField]
    private float timeToGenerate = 5;
    private float currentTime = 0;
    [SerializeField]
    private GameObject Obstacle;

    private void Awake()
    {
        currentTime = timeToGenerate;
    }
    void Update()
    {
        currentTime-= Time.deltaTime;
        if(currentTime <= 0)
        {
            currentTime = timeToGenerate;
            Generate();
        }
    }

    private void Generate()
    {
        GameObject.Instantiate(Obstacle, transform.position, Quaternion.identity);
        
    }
}
