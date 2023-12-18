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
    private void Update()
    {
        transform.Translate(Vector3.left*speed* Time.deltaTime);   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);
      
    }
}
