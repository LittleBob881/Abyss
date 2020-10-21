using System.Collections;
using System.Collections.Generic;
using UnityEditor.Android;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    //The door button that will be used for the process.
    public GameObject doorButton;

    // Vector variables that can be set within the door controller to make it easier to use, and are set within the door controller.
    public float x;
    public float y;

    //The gameobject that represents the player.
    public GameObject player;

    //The walk controller function, that allows the player to walk. Taken from the walk script.
    public Walk walkcontroller;



    void Start()
    {
        Debug.Log("Starting");
        // Prints out the original position of the player
        Debug.Log("X:" + player.transform.position.x + "Y:" + player.transform.position.y + "Z:" + player.transform.position.z);
        //Instantiates a Door button
        Button next = doorButton.GetComponent<Button>();
        //When the user taps on the button, loads the Loadscreen function
        next.onClick.AddListener(Loadscreen);
        Debug.Log("Loaded click");
    }

    
    /*The Load screen function is used to transform the player to the desired vector/room, this is done by disabling the walkcontroller so that the player cannot move during the tansformation
     and then checking if the character is in the desired location, before enabling the character controller once again. The vector is set through a Door Controller that is then added to the 
    door button.*/
    public void Loadscreen()
    {
        Debug.Log("Clicked");

        //Disables the walkcontroller so that the player cant move forward during the transform to the next room.
        walkcontroller.enabled = false;
        //Transforms the player to the desired location, that is set within the door controller.
        player.transform.position = new Vector3(x, y);
        walkcontroller.enabled = true;
        //Checks if user is within the desire location
        // if (player.transform.position == transform.position)
        // {
        //Enables the player to walk again.

        // }
    }

}
