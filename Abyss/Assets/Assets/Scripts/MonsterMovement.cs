using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    private float direction;
    private float movement = 0.3f;

    private Rigidbody2D rb;
    private Vector3 localScale;
    private bool facingR = false;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        direction = -22f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 70f)
            direction = 22f;
        else if (transform.position.x > 100f)
            direction = -22f;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * movement, rb.velocity.y);
    }

    void LateUpdate()
    {
        facing();
    }

    void facing()
    {
        if (direction > 0)
            facingR = true;
        else if (direction < 0)
            facingR = false;

        if ((facingR && localScale.x < 0) || (!facingR && localScale.x > 0));
        localScale.x *= -1;

        transform.localScale = localScale;
    }
}
