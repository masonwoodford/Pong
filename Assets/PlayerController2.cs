using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    static private float max_height = 4.4F;
    static private float min_height = -4.4F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        Vector2 p = transform.position;
        if (p.y > max_height)
        {
            p.y = max_height;
            transform.position = p;
        }

        if (p.y < min_height)
        {

            p.y = min_height;
            transform.position = p;
        }
    }
}
