using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SocialPlatforms.GameCenter;

public class MonsterMovement : MonoBehaviour
{
    private float direction;
    private float movement;
    private const float walkingSpeed = 0.15f;
    private const float chasingSpeed = 0.25f;
    private const float DIRECTION_CONST = -22;
    private float LOCAL_SCALE_CONST;

    private Rigidbody2D monster;
    private GameObject player;
    private Transform playerTransform;
    private Transform monsterTransform;
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
        LOCAL_SCALE_CONST = localScale.x;
        monster = GetComponent<Rigidbody2D>();
        wallLeft = 70f;
        wallRight = 100f;
        movement = walkingSpeed;
        direction = DIRECTION_CONST;

        player = GameObject.Find("man_sheet1 (1)_0");
        playerTransform = player.transform;
        monsterTransform = monster.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //walk();
        chase();
    }

    void walk()
    {
        movement = walkingSpeed;
        if(!(monsterTransform.position.x < wallRight && monsterTransform.position.x > wallLeft))
        {
            facingR = !facingR;
        }
        else
        {
            int randomGen = rand.Next(1, 140);
            if (randomGen == 1)
            {
                facingR = !facingR;
            }
        }

        if(facingR)
        {
            direction = -DIRECTION_CONST;
            localScale.x = -LOCAL_SCALE_CONST;
        }
        else
        {
            direction = DIRECTION_CONST;
            localScale.x = LOCAL_SCALE_CONST;
        }

        monsterTransform.localScale = localScale;
        monster.velocity = new Vector2(direction * movement, monster.velocity.y);
    }

    void chase()
    {
        movement = chasingSpeed;
        float playerLocation = playerTransform.position.x;
        if(playerLocation+1 >= monsterTransform.position.x && playerLocation-1 <= monsterTransform.position.x)
        {
            Walk playerScript = (Walk)player.GetComponent(typeof(Walk));
            playerScript.killPlayer();
            player.SetActive(false);
        }
        else if(playerLocation > monsterTransform.position.x)
        {
            facingR = true;
            direction = -DIRECTION_CONST;
            localScale.x = -LOCAL_SCALE_CONST;
        }
        else
        {
            facingR = false;
            direction = DIRECTION_CONST;
            localScale.x = LOCAL_SCALE_CONST;
        }

        monsterTransform.localScale = localScale;
        monster.velocity = new Vector2(direction * movement, monster.velocity.y);
    }

}
