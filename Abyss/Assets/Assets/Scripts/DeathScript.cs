using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public GameObject DeathAnimation;
    public GameObject DeathMenu;
    public GameObject Deathtext;
    public GameObject player;
    public Walk playerWalk;
    public PuzzleScript PuzzleScript;
    public MonsterMovement Monster;
    public string LoadingPlace;

    // hides the deathmenu on at start of game
    void Start()
    {
        DeathMenu.gameObject.SetActive(false);
        DeathAnimation.gameObject.SetActive(false);   
    }

    //plays the death anamation and activates the death menu when player has died 
    public void PlayerDeath()
    {
        DeathAnimation.gameObject.SetActive(true);
        DeathMenu.gameObject.SetActive(true);
    }
    
    // makes the death anaimation not visable
    public void OpenDeathMenu()
    {
        DeathAnimation.gameObject.SetActive(false);
    }

    // if there is a save file it will load the safe file. if there is not save file it will start a new game. 
    // resets the puzzles 
    // hides the death menu
    // reset the player
    // resets the monster
    public void Tryagain()
    {
        PuzzleScript.Tryagain();
        DeathMenu.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        player.transform.position = new Vector3(playerWalk.respawnPoint.x, playerWalk.respawnPoint.y);
        Monster.ResetMonster();
    }

    // resets the puzzles 
    // hides the death menu
    // reset the player
    // resets the monster
    public void NewGame()
    {
        PuzzleScript.NewGame();
        DeathMenu.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        player.transform.position = new Vector3(playerWalk.respawnPoint.x, playerWalk.respawnPoint.y);
        Monster.ResetMonster();
    }

    // loads main menu
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
