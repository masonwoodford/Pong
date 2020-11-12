using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle1;
    public GameObject paddle2;
    public Text score1;
    public Text score2;
    public float speed;
    private int hr_direction;
    private int vr_direction;
    private int int_score1;
    private int int_score2;
    private int temp_int;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 p = transform.position;
        p.x = 0;
        p.y = UnityEngine.Random.Range(-2f, 2f);
        transform.position = p;
        AssignDirections();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 p = transform.position;
        if (p.x <= -6.12)
        {
            int_score2++;
            temp_int = int_score2;
            score2.text = temp_int.ToString();
            p.x = 0;
            p.y = UnityEngine.Random.Range(-2f, 2f);
            transform.position = p;
            AssignDirections();
        }
        if (p.x >= 6.12)
        {
            int_score1++;
            temp_int = int_score1;
            score1.text = temp_int.ToString();
            p.x = 0;
            p.y = UnityEngine.Random.Range(-2f, 2f);
            transform.position = p;
            AssignDirections();
        }
        WallCollision();
        PaddleCollision();
        if (hr_direction == 1)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (vr_direction == 1)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
    }

    void AssignDirections()
    {
        hr_direction = UnityEngine.Random.Range(0, 2);
        vr_direction = UnityEngine.Random.Range(0, 2);
    }

    void WallCollision()
    {
        Vector2 p = transform.position;
        if (p.y > 4.47 || p.y < -4.47)
        {
            if (vr_direction == 1)
            {
                vr_direction = 0;
            }
            else
            {
                vr_direction = 1;
            }
        }
    }

    void PaddleCollision()
    {
        Vector2 ball = transform.position;
        float pos = .03f;
        float padding = .292f;
        Vector2 p1 = paddle1.transform.position;
        Vector2 p2 = paddle2.transform.position;

        if (ball.x <= p1.x + padding && ball.x < 0)
        {
            ball.x = p1.x + pos + padding;
            if (ball.y > p1.y && ball.y <= p1.y + .52)
            {
                if (vr_direction == 1)
                {
                    vr_direction = 0;
                }
                else
                {
                    vr_direction = 1;
                }
                if (hr_direction == 1)
                {
                    hr_direction = 0;
                }
                else
                {
                    hr_direction = 1;
                }
            }
            else if (ball.y < p1.y && ball.y >= p1.y - .52)
            {
                if (vr_direction == 1)
                {
                    vr_direction = 0;
                }
                else
                {
                    vr_direction = 1;
                }
                if (hr_direction == 1)
                {
                    hr_direction = 0;
                }
                else
                {
                    hr_direction = 1;
                }
            }
        }
        else if (ball.x >= p2.x - padding && ball.x > 0)
        {
            ball.x = p2.x - pos - padding;
            if (ball.y > p2.y && ball.y <= p2.y + .52)
            {
                UnityEngine.Debug.Log("a");
                if (vr_direction == 1)
                {
                    vr_direction = 0;
                }
                else
                {
                    vr_direction = 1;
                }
                if (hr_direction == 1)
                {
                    hr_direction = 0;
                }
                else
                {
                    hr_direction = 1;
                }
            }
            else if (ball.y < p2.y && ball.y >= p2.y - .52)
            {
                UnityEngine.Debug.Log("b");
                if (vr_direction == 1)
                {
                    vr_direction = 0;
                }
                else
                {
                    vr_direction = 1;
                }
                if (hr_direction == 1)
                {
                    hr_direction = 0;
                }
                else
                {
                    hr_direction = 1;
                }
            }
        }
    }
}
