using System.Collections;
using System.Collections.Generic;
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

    

    void Start()
    {
        Debug.Log("Starting");
        Debug.Log("X:" + player.transform.position.x + "Y:" + player.transform.position.y + "Z:" + player.transform.position.z);
        //Instantiates a Door button
        Button next = doorButton.GetComponent<Button>();
        next.onClick.AddListener(Loadscreen);
        Debug.Log("Loaded click");
    }

    public void Loadscreen()
    {
        Debug.Log("Clicked");

        walkcontroller.enabled = false;
        player.transform.position = new Vector3(x, y);

        if (player.transform.position == transform.position)
        {
            walkcontroller.enabled = true;
            Debug.Log("Are you listening??");
        }
    }
}
