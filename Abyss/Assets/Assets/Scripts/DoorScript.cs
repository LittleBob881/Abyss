using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    private bool showPopup = false;
    private AssetBundle loadedAssets;
    private string[] scenes;
    public GameObject doorButton;
    public string scene;

    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("C:\\users\\kiwik\\OneDrive\\Documents\\GitHub\\Abyss\\Abyss\\Assets\\Scenes");
        scenes = loadedAssets.GetAllScenePaths();

        Button next = doorButton.GetComponent<Button>();
        next.onClick.AddListener(loadscreen);
    }

    public void loadscreen() 
    {
        Debug.Log("Scene loading: " + scene);
        SceneManager.LoadScene(scene);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("doorButton").GetComponent<Button>().interactable = true;
            Debug.Log("Entering Collision");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("LeavingCollision");
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("doorButton").GetComponent<Button>().interactable = false;
            Debug.Log("Entering Collision");
        }
    }
}
