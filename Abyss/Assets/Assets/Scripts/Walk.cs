using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float speed;
    private float walkSound = 2f;
    public bool alive = true;
    private AudioSource audioSrc;
    public DeathScript DeathScript;
    public Vector3 respawnPoint;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = 5f;
    }

    private void Update()
    {
        //This will play the walking sound, stops when the player is idle and plays sound when the player is on the move
        audioSrc = GetComponent<AudioSource>();
        //Updates scale x of the character depending on which side the character is facing (Left -, right +)
        Vector3 characterScale = transform.localScale;
        //Takes in touch count from Android device (up to 5 fingers touch)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Switch case to make the character walk either left or right. Play sound as the player is walking and update the scale x
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

    //Is used by the monster movement script to kill the player
    public void killPlayer()
    {
        alive = false;
        DeathScript.PlayerDeath();
    }

    //Collider used with IsTrigger to save Mirror in safe room as respawn Point
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LoadingPoint")
        {
            respawnPoint = collision.transform.position;
        }
    }
}
