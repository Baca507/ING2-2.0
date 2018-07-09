using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Create a box sprite which falls and hits a floor sprite.  The box can be moved/animated
// with the up, left, right, and down keys.  Moving the box sprite upwards and letting it
// fall will increate the number of calls from OnCollisionEnter2D.

public class Example1 : MonoBehaviour
{
    public Texture2D tex;

    void Awake()
    {
        SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        transform.position = new Vector3(0.0f, 2.5f, 0.0f);

        Sprite sp = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        sr.sprite = sp;

        gameObject.AddComponent<BoxCollider2D>();

        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        gameObject.transform.Translate(moveHorizontal * 0.05f, moveVertical * 0.25f, 0.0f);
    }

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
    }
}
