﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float shrinkSpeed = 3f;
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime ;
        if(transform.localScale.x <= 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
