using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador2 : MonoBehaviour
{
    float a = 20f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * a  * 10 * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * a * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * a * 10 * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * a  * Time.deltaTime);
    }
}
//Es para mover y Rotar//﻿
