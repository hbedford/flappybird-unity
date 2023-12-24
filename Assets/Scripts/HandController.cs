using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private SpriteRenderer image;
   private  void Awake()
    {
        image = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Hide();
        }
    }

    private void Hide()
    {
        image.enabled = false;
    }
}
