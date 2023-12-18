using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Rigidbody2D physic;
    [SerializeField]
    private float force = 5;
    private GameController GameController;
    private Vector3 positionInitial;

    private void Awake()
    {
        positionInitial = transform.position;
        physic = GetComponent<Rigidbody2D>(); 
    }

    private void Start()
    {
        GameController = GameObject.FindAnyObjectByType<GameController>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           Push();
        }
    }

    private void Push()
    {
        physic.velocity = Vector2.zero;
        physic.AddForce(Vector2.up*force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        physic.simulated = false;

        GameController.EndGame();

    }

    public  void Restart()
    {
        transform.position = positionInitial;
        physic.simulated = true;
    }
}
