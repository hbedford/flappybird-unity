using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Rigidbody2D physic;
    [SerializeField]
    private float force = 5;

    private void Awake()
    {
        physic = GetComponent<Rigidbody2D>(); 
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
}
