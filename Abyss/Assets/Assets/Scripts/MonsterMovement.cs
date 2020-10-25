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
    private AudioSource monsterSound;
    private bool playerAlive = true;

    //Variables for randomized walking
    private float floorPosition;
    private float wallLeft;
    private float wallRight;
    private float door1Position;
    private float door2Position = 0;
    private System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        monsterSound = GetComponent<AudioSource>();
        localScale = transform.localScale;
        LOCAL_SCALE_CONST = localScale.x;
        monster = GetComponent<Rigidbody2D>();

        LoadMonsterPosition();

        player = GameObject.Find("Player");
        playerTransform = player.transform;
        monsterTransform = monster.transform;
    }

    private void LoadMonsterPosition()
    {
        wallLeft = 65f;
        wallRight = 100f;
        movement = walkingSpeed;
        direction = DIRECTION_CONST;
        door1Position = 67.5f;
        floorPosition = -30.82f;
        //playerAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if((playerTransform.position.y <= floorPosition+0.5f && playerTransform.position.y >= floorPosition-0.5f) && (playerTransform.position.x <= wallRight && playerTransform.position.x >= wallLeft))
        {
           chase();
        }
        else
        {
            walk();
        }
    }

    void walk()
    {
        movement = walkingSpeed;
        if (monsterTransform.position.x <= door1Position + 0.05f && monsterTransform.position.x >= door1Position)
        {
            AtDoor();
        }
        else if (door2Position != 0 && monsterTransform.position.x <= door2Position + 0.05f && monsterTransform.position.x >= door2Position)
        {
            AtDoor();
        }
        else if (!(monsterTransform.position.x < wallRight && monsterTransform.position.x > wallLeft))
        {
            facingR = !facingR;
        }
        else
        {
            //Chooses a random number 1-200 and will turn if the random number is 200
            int randomGen = rand.Next(1, 200);
            if (randomGen == 1)
            {
                facingR = !facingR;
            }
        }

        //Checks which way the monster is facing and changes which way it is walking to match
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

        //Refreshes the image and velocity to the direction
        monsterTransform.localScale = localScale;
        monster.velocity = new Vector2(direction * movement, monster.velocity.y);
    }

    private void AtDoor()
    {
        //Has a 1 in 3 chance of going through the door
        int randomGen = rand.Next(1, 3);
        if (randomGen == 1)
        {
            throughDoor();
            monsterTransform.position = new Vector3(door1Position, floorPosition);
            monster.velocity = new Vector2(direction * movement, monster.velocity.y);
        }
    }

    void chase()
    {
        movement = chasingSpeed;
        float playerLocation = playerTransform.position.x;
        if(playerLocation+0.5f >= monsterTransform.position.x && playerLocation-0.5f <= monsterTransform.position.x && playerAlive)
        {
            Walk playerScript = (Walk)player.GetComponent(typeof(Walk));
            playerScript.killPlayer();
            playerAlive = false;
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
        //This sets the new doors and floor position for the monster when it goes through each door
        float monsterX = monsterTransform.position.x;
        float monsterY = monsterTransform.position.y;

        if(monsterY == -30.82f && monsterX <= 68.5f && monsterX >= 66.5f)
        {
            Debug.Log("Going from Lounge to Green Hall");
            door1Position = 77f;
            floorPosition = -17.58f;
            wallLeft = 64.5f;
            wallRight = 96.3f;
            door2Position = 92f;
        }
        else if(monsterY == -17.58f && monsterX <= 78 && monsterX >= 76)
        {
            Debug.Log("Going from Green Hall to Lounge");
            door1Position = 67.5f;
            floorPosition = -30.82f;
            wallLeft = 65f;
            wallRight = 100f;
            door2Position = 0;
        }
        else if (monsterY == -17.58f && monsterX <= 93 && monsterX >= 91)
        {
            Debug.Log("Going from Green Hall to Bedroom");
            door1Position = 80.7f;
            floorPosition = 1.62f;
            wallLeft = 64.5f;
            wallRight = 99.5f;
            door2Position = 0;
        }
        else if (monsterY == 1.62f && monsterX <= 81.7f && monsterX >= 79.7f)
        {
            Debug.Log("Going from Bedroom to Green Hall");
            door1Position = 92f;
            floorPosition = -17.58f;
            wallLeft = 64.5f;
            wallRight = 96.3f;
            door2Position = 77f;
        }
    }

    // stop monster from killing player in end game menu
    public void StopMonster()
    {
        playerAlive = false;
    }
}
