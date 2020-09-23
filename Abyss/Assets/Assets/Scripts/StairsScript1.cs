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
    int currentfloor;

    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("");
        scenes = loadedAssets.GetAllScenePaths();
    }
    

    void OnGUI()
    {
        if (showPopup)
        {
           // GUI.Window(0, new rect((Screen.width / 2) - 150, (Screen.height / 2), 300, 250, ShowGUI, "Which way?"));
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
