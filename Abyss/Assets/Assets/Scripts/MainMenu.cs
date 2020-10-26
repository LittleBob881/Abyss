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
        //This code will load scene number 1 which is World scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContiuneGame()
    {
        load.setLoadcontuie(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
