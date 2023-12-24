using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopController : MonoBehaviour
{
    [SerializeField]
    private VariableFloatShared Speed;
    private Vector3 positionInitial;
    private float sizeOfGround;

    private void Awake()
    {
        positionInitial = transform.position;
        float realSizeOfGround = GetComponent<SpriteRenderer>().size.x;
        sizeOfGround = realSizeOfGround *transform.localScale.x;
    }
    void Update()
    {
       float movement = Mathf.Repeat(Speed.value * Time.time,sizeOfGround);
        transform.position =positionInitial +Vector3.left * movement;


        
    }
}
