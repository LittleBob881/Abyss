using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private float horizontal;
    private bool facingRight;

    private void Start()
    {
        facingRight = true;
    }

    public void flipCharacter(float hori)
    {
        hori = this.horizontal;
        if (hori > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    public float getScale()
    {

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        return scale.x;
    }
}
