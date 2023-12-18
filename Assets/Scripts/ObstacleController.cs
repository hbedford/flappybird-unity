using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;
    [SerializeField]
    private float variationPositionY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variationPositionY, variationPositionY));
    }
    void Update()
    {
        transform.Translate(Vector3.left*speed* Time.deltaTime);   
    }
}
