using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float speed;
    private AudioSource audioSrc;
    private float walkSound = 2f;
    private bool alive = true;

    public DeathScript DeathScript;

    public Vector3 respawnPoint;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
       // audioSrc = GetComponent<AudioSource>();
        speed = 5f;
    }

    private void Update()
    {
        audioSrc = GetComponent<AudioSource>();
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
                        audioSrc.pitch = walkSound;
                    }

                    //Right
                    if (touch.position.x > Screen.width / 2)
                    {
                        characterScale.x = 22;
                        rigid.velocity = new Vector2(speed, 0f);
                        audioSrc.Play();
                        audioSrc.pitch = walkSound;
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

    public void killPlayer()
    {
        alive = false;
        Debug.Log("Player is dead");
        DeathScript.PlayerDeath();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Monster")
        {
           //
        }

        if(collision.tag == "LoadingPlace")
        {
            respawnPoint = collision.transform.position; 
        }
    }
}
