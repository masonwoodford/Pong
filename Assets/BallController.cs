using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        Instantiate(ball, new Vector2(0, UnityEngine.Random.Range(-4f, 4f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
