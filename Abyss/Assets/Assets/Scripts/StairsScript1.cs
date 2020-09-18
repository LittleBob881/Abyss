using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsScript : MonoBehaviour
{
    private bool showPopup = false;
    // Start is called before the first frame update

    private AssetBundle loadedAssets;
    private string[] scenes;
    int currentfloor;

    void Start()
    {
        loadedAssets = AssestBundle.LoadFromFile("");
        scenes = loadedAssets.getAllScenePaths();
    }
    

    void OnGUI()
    {
        if (showPopup)
        {
            GUI.Window(0, new rect((Screen.width / 2) - 150, (Screen.height / 2), 300, 250, ShowGUI, "Which way?"));
        }
    }

    void ShowGUI(int windowID)
    {
        GUI.Label(new Rect(65, 40, 200, 30), "Would you like to go up or down?");

        if (OnGUI.Button(new Rect(50, 150, 75, 30), "Up"))
        {
            Debug.log("Scene loading: " + scenes[currentfloor + 1]);
            ScenesManager.LoadScene(scenes[currentfloor + 1], LoadSceneMode.Single);
        }

        if (OnGUI.Button(new Rect(50, 150, 75, 30), "Down"))
        {
            Application.LoadLevel("Down");
            Debug.log("Scene loading: " + scenes[currentfloor - 1]);
            ScenesManager.LoadScene(scenes[currentfloor - 1], LoadSceneMode.Single);
        }

    }
}
