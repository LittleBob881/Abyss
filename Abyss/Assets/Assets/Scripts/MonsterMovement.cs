using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class MonsterMovement : MonoBehaviour
{
    private float direction;
    private float movement = 0.3f;

    private Rigidbody2D rb;
    private Vector3 localScale;
    private bool facingR;

    //Variables for randomized walking
    private float floorPosition;
    private float wallLeft;
    private float wallRight;
    private float doorPosition;
    private System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        direction = -22f;
        facingR = false;
        wallLeft = 70f;
        wallRight = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        walk();
    }

    void walk()
    {
        if(!(transform.position.x < wallRight && transform.position.x > wallLeft))
        {
            direction *= -1;
            localScale.x *= -1;
        }
        else
        {
            int randomGen = rand.Next(1, 100);
            if (randomGen == 1)
            {
                direction *= -1;
                localScale.x *= -1;
            }
        }
        transform.localScale = localScale;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * movement, rb.velocity.y);
    }

    //void LateUpdate()
    //{
    //    facing();
    //}

    //void facing()
    //{
    //    if (direction > 0)
    //        facingR = true;
    //    else if (direction < 0)
    //        facingR = false;

    //    if ((facingR && localScale.x < 0) || (!facingR && localScale.x > 0));
    //    localScale.x *= -1;

    //    transform.localScale = localScale;
    //}
}
