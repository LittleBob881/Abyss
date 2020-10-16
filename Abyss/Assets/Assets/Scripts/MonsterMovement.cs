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
    private float door1Position;
    private float door2Position = 0;
    private float door3Position = 0;
    private System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        LOCAL_SCALE_CONST = localScale.x;
        monster = GetComponent<Rigidbody2D>();
        wallLeft = 65f;
        wallRight = 100f;
        movement = walkingSpeed;
        direction = DIRECTION_CONST;
        door1Position = 67.5f;
        floorPosition = -32f;

        player = GameObject.Find("Player");
        playerTransform = player.transform;
        monsterTransform = monster.transform;
    }

    // Update is called once per frame
    void Update()
    {
        walk();
        //chase();
    }

    void walk()
    {
        movement = walkingSpeed;
        if (monsterTransform.position.x <= door1Position + 0.1f && monsterTransform.position.x >= door1Position)
        {
            int randomGen = rand.Next(1, 3);
            if (randomGen == 1)
            {
                throughDoor();
                monsterTransform.position = new Vector3(door1Position, floorPosition);
                monster.velocity = new Vector2(direction * movement, monster.velocity.y);
            }
        }
        else if (door2Position != 0 && monsterTransform.position.x <= door2Position + 0.1f && monsterTransform.position.x >= door2Position)
        {
            Debug.Log("WALKING PAST SECOND DOOR");
            int randomGen = rand.Next(1, 3);
            if (randomGen == 1)
            {
                throughDoor();
                monsterTransform.position = new Vector3(door1Position, floorPosition);
                monster.velocity = new Vector2(direction * movement, monster.velocity.y);
            }
        }
        else if (!(monsterTransform.position.x < wallRight && monsterTransform.position.x > wallLeft))
        {
            facingR = !facingR;
        }
        else
        {
            //int randomGen = rand.Next(1, 140);
            //if (randomGen == 1)
            //{
            //    facingR = !facingR;
            //}
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

    void throughDoor()
    {
        float monsterX = monsterTransform.position.x;
        float monsterY = monsterTransform.position.y;

        if(monsterY == -32f && monsterX <= 68.5f && monsterX >= 66.5f)
        {
            Debug.Log("Going from Lounge to Green Hall");
            door1Position = 77f;
            floorPosition = -18f;
            wallLeft = 64.5f;
            wallRight = 96.3f;
            door2Position = 92f;
        }
        else if(monsterY == -18 && monsterX <= 78 && monsterX >= 76)
        {
            Debug.Log("Going from Green Hall to Lounge");
            door1Position = 67.5f;
            floorPosition = -32f;
            wallLeft = 65f;
            wallRight = 100f;
            door2Position = 0;
        }
    }
}
