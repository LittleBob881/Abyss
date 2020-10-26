﻿using System.Collections;
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
        //This code will load scene number 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContiuneGame()
    {
        Debug.Log("Game contniue Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        loadContinue.setLoadcontuie(true);
    }

    public void QuitGame()
    {
        Debug.Log("Game Quitting");
        Application.Quit();
    }


}
