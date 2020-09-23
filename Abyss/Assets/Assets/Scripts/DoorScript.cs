using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private bool showPopup = false;
    private AssetBundle loadedAssets;
    private string[] scenes;
    public bool isInRange;
    public string scene;

    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("C:\\users\\kiwik\\OneDrive\\Documents\\GitHub\\Abyss\\Abyss\\Assets\\Scenes");
        scenes = loadedAssets.GetAllScenePaths();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
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
            isInRange = true;
            Debug.Log("Entering Collision");
            showPopup = false;
        }
    }


    void OnGUI()
    {
        if (showPopup)
        {
            GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75, 300, 250), ShowGUI, "Which way?");
        }
    }

    void ShowGUI(int windowID)
    {
        GUI.Label(new Rect(65, 40, 200, 30), "Go into the lounge?");

        if (GUI.Button(new Rect(50, 150, 75, 30), "Yes"))
        {
            Debug.Log("Scene loading: " + scene);
            SceneManager.LoadScene(scene);
        }

    }
}
