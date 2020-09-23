using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairsScript : MonoBehaviour
{
    private bool showPopup = false;
    // Start is called before the first frame update

    private AssetBundle loadedAssets;
    private string[] scenes;
    public bool isInRange;

    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("C:\\users\\kiwik\\OneDrive\\Documents\\GitHub\\Abyss\\Abyss\\Assets\\Scenes");
        scenes = loadedAssets.GetAllScenePaths();
    }

    void Update()
    {
        if (isInRange) { 
            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;
                if (Physics.Raycast(raycast, out raycastHit))
                {
                    Debug.Log("Something Hit");
                    if (raycastHit.collider.name == "Box Collider 2D")
                    {
                        Debug.Log("Soccer Ball clicked");
                    }
                }
            }
        }
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
        GUI.Label(new Rect(65, 40, 200, 30), "Would you like to go up or down?");

        if (GUI.Button(new Rect(50, 150, 75, 30), "Up"))
        {
            Debug.Log("Scene loading: " + "Top Floor");
            SceneManager.LoadScene("hallway_Top");
        }

        if (GUI.Button(new Rect(150, 150, 75, 30), "Down"))
        {
            Debug.Log("Scene loading: " + "Bottom Floor");
            SceneManager.LoadScene("hallway_Bottom");
        }

    }
}
