using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairsScript : MonoBehaviour
{
    private bool showPopup = false;
    public bool isInRange;
    public GameObject player;
    public Walk walkcontroller;

    int df_x;
    int df_y;

    void Start()
    {
        Debug.Log("Starting");
        Debug.Log("X:" + player.transform.position.x + "Y:" + player.transform.position.y + "Z:" + player.transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Activates the pop up when the user is within the collision range.
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Player")
        {

            isInRange = true;
            Debug.Log("Entering Collision");
            showPopup = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("LeavingCollision");
        if (collision.gameObject.tag == "Player")
        {
            //Deactivates pop up once leaving the collision range.
            isInRange = true;
            Debug.Log("Entering Collision");
            showPopup = false;
        }
    }

    public void LoadscreenLower()
    {
        Debug.Log("Loading Scene: Lower Floor");

        walkcontroller.enabled = false;
        player.transform.position = new Vector3(df_x, df_y);

        if (player.transform.position == transform.position)
        {
            
            walkcontroller.enabled = true;
            Debug.Log("Are you listening??");
        }
    }

    public void LoadscreenUp()
    {
        

        Debug.Log("Loading Scene: Upper Floor");
        walkcontroller.enabled = false;
        Debug.Log("Loading");
        player.transform.position = new Vector3(-3.3f, -17.1f);
        if (player.transform.position == transform.position)
        {
            walkcontroller.enabled = true;
            Debug.Log("Are you listening??");
        }
    }


    void OnGUI()
    {
        //Creates a pop up
        if (showPopup)
        {
            GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75, 300, 250), ShowGUI, "Which way?");
        }
    }

    void ShowGUI(int windowID)
    {
        //Creating assets within the pop, such as buttons and labels
            GUI.Label(new Rect(65, 40, 200, 30), "Would you like to go up or down?");
            if (GUI.Button(new Rect(50, 150, 75, 30), "Up"))
        {
            Debug.Log("Clicked");
            LoadscreenUp();
            //Loads the upper hallway upon interact
            
            
        }

        if (GUI.Button(new Rect(150, 150, 75, 30), "Down"))
        {
            //Loads the lower hallway upon interact
            Debug.Log("Clicked");
            LoadscreenLower();
            
        }
    }
}
