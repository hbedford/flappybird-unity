using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private float timeSpent;
    [SerializeField]
    private float timeMaxLevel;
    public float Level { get; private set; }
    void Update()
    {
        timeSpent += Time.deltaTime;
       Level = timeSpent / timeMaxLevel;
       Level = Mathf.Min(1, Level);

        
    }
}
