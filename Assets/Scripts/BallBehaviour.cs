﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Transform paddle;
    bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            float posDiff = paddle.position.x - transform.position.x;
            transform.position = new Vector3(paddle.position.x - posDiff, paddle.position.y, paddle.position.z);
            if(Input.GetMouseButtonDown(0))
            {
                gameStarted = true;
            }
        }
        
    }
}
