using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StairsScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    private bool showPopup = false;
    private AssetBundle loadedAssets;
    private string[] scenes;
    int currentfloor = 1;
    public bool isinRange;
    public KeyCode interact;
    public UnityEvent interactAction;


    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("C:\\Users\\kiwik\\OneDrive\\Documents\\GitHub\\Abyss\\Abyss\\Assets\\Scenes");
        scenes = loadedAssets.GetAllScenePaths();
    }

    void Update()
    {
        if (isinRange) {
            if (Input.touchCount > 0) {
                interactAction.Invoke();
             }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.CompareTag("Player")) {
            isinRange = true;
            Debug.Log("Player is in range");
            showPopup = true;
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
            Debug.Log("Scene loading: " + scenes[currentfloor + 1]);
            SceneManager.LoadScene(scenes[currentfloor + 1], LoadSceneMode.Single);
        }

        if (GUI.Button(new Rect(50, 150, 75, 30), "Down"))
        {
            Debug.Log("Scene loading: " + scenes[currentfloor - 1]);
            SceneManager.LoadScene(scenes[currentfloor - 1], LoadSceneMode.Single);
        }

    }
}
 
