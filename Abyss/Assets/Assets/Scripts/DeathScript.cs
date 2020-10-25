using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public GameObject DeathAnimation;
    public GameObject DeathMenu;
    public GameObject Deathtext;
    public PuzzleScript PuzzleScript;
    public MonsterMovement MonsterMovement;

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
        PuzzleScript.NewGame();
        PuzzleScript.TestLoadPuzzleSave();
        DeathMenu.gameObject.SetActive(false);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        MonsterMovement.LoadMonsterPosition();
        PuzzleScript.NewGame();
        DeathMenu.gameObject.SetActive(false);
        //reset player
<<<<<<< Updated upstream
        // reset monster
=======
        


>>>>>>> Stashed changes
    }
}
