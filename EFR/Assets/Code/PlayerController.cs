using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    private int dir = 0;
    [SerializeField] private Animator anim;
    public bool isInverse = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (direction.y == 0 && direction.x == 0)
            dir = 0;
        if (direction.x > 0)
            dir = 1;
        if (direction.y < 0)
            dir = 2;
        if (direction.x < 0)
            dir = 3;
        if (direction.y > 0)
            dir = 4;

        anim.SetInteger("Direction", dir);
    }

    void FixedUpdate()
    {
        if (!isInverse)
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        else
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime * (-1));
    }
}
