using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource MainMenuSound;
    public MenuLoadscript loadContinue;

    private void Start()
    {
        MainMenuSound = GetComponent<AudioSource>();
        MainMenuSound.Play();
    }
    public void StartGame()
    {
        //When the start button is tapped, the game will load with scenemanager
        Debug.Log("Game Started");
        //This code will load scene number 1 by adding 1 to current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContiuneGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        loadContinue.loadContinue = true;
    }

    public void QuitGame()
    {
        Debug.Log("Game Quitting");
        Application.Quit();
    }


}
