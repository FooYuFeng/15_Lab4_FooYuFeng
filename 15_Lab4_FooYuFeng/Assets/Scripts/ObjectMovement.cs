﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -4f * Time.deltaTime, 0f);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
