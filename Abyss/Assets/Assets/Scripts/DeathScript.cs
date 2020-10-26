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



    public void Tryagain()
    {
        NewGame();
        
        PuzzleScript.Tryagain();
        
    }

    public void NewGame()
    {
        PuzzleScript.Tryagain();
        DeathMenu.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        // player.alive = true;
        player.transform.position = new Vector3(playerWalk.respawnPoint.x, playerWalk.respawnPoint.y);
        Monster.StopMonster();
        
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);

    }
}
