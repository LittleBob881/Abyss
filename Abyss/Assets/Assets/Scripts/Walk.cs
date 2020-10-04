using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float speed;
    private AudioSource audioSrc;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        audioSrc = GetComponent<AudioSource>();
        speed = 5f;
    }

    private void Update()
    {
        Vector3 characterScale = transform.localScale;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //Left
                    if (touch.position.x < Screen.width / 2)
                    {
                        characterScale.x = -22;
                        rigid.velocity = new Vector2(-speed, 0f);
                        audioSrc.Play();
                    }

                    //Right
                    if (touch.position.x > Screen.width / 2)
                    {
                        characterScale.x = 22;
                        rigid.velocity = new Vector2(speed, 0f);
                        audioSrc.Play();
                    }
                    break;

                case TouchPhase.Ended:
                    rigid.velocity = new Vector2(0f, 0f);
                    audioSrc.Stop();
                    break;
            }
        }
        transform.localScale = characterScale;
    }
}
