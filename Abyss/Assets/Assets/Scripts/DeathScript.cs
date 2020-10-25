﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject DeathAnimation;
    public GameObject DeathMenu;
    public GameObject Deathtext;
    public PuzzleScript PuzzleScript;

    // Start is called before the first frame update
    void Start()
    {
        DeathMenu.gameObject.SetActive(false);
        DeathAnimation.gameObject.SetActive(false);
        
    }


    public void PlayerDeath()
    {
        DeathAnimation.gameObject.SetActive(true);
        DeathMenu.gameObject.SetActive(true);
    }

    public void OpenDeathMenu()
    {
        DeathAnimation.gameObject.SetActive(false);
    }



    public void LoadSave()
    {
        NewGame();
        PuzzleScript.TestLoadPuzzleSave();
        
    }

    public void NewGame()
    {
        PuzzleScript.NewGame();
        DeathMenu.gameObject.SetActive(false);
        //reset player
        // reset monster
        
    }
}
