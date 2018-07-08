using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour {
    public float speed;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moverHorizontal,moverVertical,0.0f);

        rb.AddForce(movimiento * speed * Time.deltaTime);
        
    }
}
