using System.Collections;
using System.Collections.Generic;
using UnityEditor.Android;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    
    public GameObject doorButton;
    //public Transform Camera;
    //Calls a string from unity to load a scene
    public bool enable_camera = true;
    public bool trigger = true;
    public float x;
    public float y;
    public GameObject player;
    public Walk walkcontroller;
    private Vector3 offset;



    void Start()
    {
        Debug.Log("Starting");
        Debug.Log("X:" + player.transform.position.x + "Y:" + player.transform.position.y + "Z:" + player.transform.position.z);
        //Instantiates a Door button
        Button next = doorButton.GetComponent<Button>();
        next.onClick.AddListener(Loadscreen);
        Debug.Log("Loaded click");
        offset = transform.position - player.transform.position;
    }

    

    public void Loadscreen()
    {
        Debug.Log("Clicked");

        walkcontroller.enabled = false;
        player.transform.position = new Vector3(x, y);

        if (player.transform.position == transform.position)
        {
            walkcontroller.enabled = true;
           // transform.position = player.transform.position + offset;
        }
        Debug.Log("Are you listening??");
    }

    /* public void Loadscreen() 
     {
         //Loads a screen depending on string name
         Debug.Log("Clicked");
         GameObject.Find("Main Camera").transform.position = new Vector3(4110, -33, 0);
         


     }*/



    /* void OnTriggerEnter2D(Collider2D collision)
     {
         //Upon player collision, the button will be able to be interactable and print the player is within collision range.
         Debug.Log("Collision");
         if (collision.gameObject.CompareTag("Player"))
         {
             Debug.Log("Entering Collision");
             GameObject.Find("doorButton").GetComponent<Button>().interactable = true;
             trigger = true;
             enable_camera = true;

         }
     }

     private void OnTriggerExit2D(Collider2D collision)
     {
         //Upon player leaving the collision zone, the button will not be interactable. 
         Debug.Log("LeavingCollision");
         if (collision.gameObject.tag == "Player")
         {
             trigger = false;
             enable_camera = false;
             GameObject.Find("doorButton").GetComponent<Button>().interactable = false;
             Debug.Log("EXiting Collision");
         }
     }*/
}
