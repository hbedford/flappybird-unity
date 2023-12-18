using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;
    [SerializeField]
    private float variationPositionY;
    private Vector3 planePosition;
    private bool addScore = false;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variationPositionY, variationPositionY));

        planePosition = GameObject.FindObjectOfType<Plane>().transform.position;
    }
    private void Update()
    {
        transform.Translate(Vector3.left*speed* Time.deltaTime);   
        if(transform.position.x < planePosition.x && !addScore)
        {
            addScore = true;
            GameObject.FindObjectOfType<GameController>().AddScore();


        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(gameObject);
      
    }
}
