using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = 10f;
    }

    private void Update()
    {
        Vector2 characterScale = transform.localScale;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //Left
                    if (touch.position.x < Screen.width / 2)
                        rigid.velocity = new Vector2(-speed, 0f);
                    characterScale.x = 22;

                    //Right
                    if (touch.position.x > Screen.width / 2)
                        rigid.velocity = new Vector2(speed, 0f);
                    characterScale.x = -22;
                    break;

                case TouchPhase.Ended:
                    rigid.velocity = new Vector2(0f, 0f);
                    break;
            }
        }
        //transform.localScale = characterScale;
    }
}
