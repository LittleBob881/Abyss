using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource MainMenuSound;
    public GameObject loadContinue;
    public MenuLoadscript load;

    private void Start()
    {
        load = loadContinue.GetComponent<MenuLoadscript>();
        DontDestroyOnLoad(loadContinue);
        MainMenuSound = GetComponent<AudioSource>();
        MainMenuSound.Play();
    }
    public void StartGame()
    {
        //When the start button is tapped, the game will load with scenemanager
        Debug.Log("Game Started");
        //This code will load scene number 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContiuneGame()
    {
        load.setLoadcontuie(true);
        Debug.Log("Game contniue Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void QuitGame()
    {
        Debug.Log("Game Quitting");
        Application.Quit();
    }


}
