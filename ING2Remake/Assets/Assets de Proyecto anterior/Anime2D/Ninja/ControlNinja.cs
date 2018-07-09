using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNinja : MonoBehaviour {
    private Animator animator;
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        dest = transform.position;
    }

    void FixedUpdate()
    {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
        // Check for Input if not moving
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
            animator.SetTrigger("Run");
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            animator.SetTrigger("Run");
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
            animator.SetTrigger("Runi");
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;
            animator.SetTrigger("Run");
        }
    }

    bool valid(Vector2 dir)
    {
        // Cast Line from 'next to Pac-Man' to 'Pac-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}
