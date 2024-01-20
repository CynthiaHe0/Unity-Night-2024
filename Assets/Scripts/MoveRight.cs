using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public float speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(speed * Vector2.right);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(speed * Vector2.left);
        }
    }

}
