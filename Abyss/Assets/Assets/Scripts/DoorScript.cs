using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    
    public GameObject doorButton;
    //Calls a string from unity to load a scene
    public string scene;

    void Start()
    {
        //Instantiates a Door button
        Button next = doorButton.GetComponent<Button>();
        next.onClick.AddListener(loadscreen);
    }

    public void loadscreen() 
    {
        //Loads a screen depending on string name
        
        Debug.Log("Scene loading: " + scene);
        SceneManager.LoadScene(scene);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Upon player collision, the button will be able to be interactable and print the player is within collision range.
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("doorButton").GetComponent<Button>().interactable = true;
            Debug.Log("Entering Collision");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Upon player leaving the collision zone, the button will not be interactable. 
        Debug.Log("LeavingCollision");
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("doorButton").GetComponent<Button>().interactable = false;
            Debug.Log("EXiting Collision");
        }
    }
}
