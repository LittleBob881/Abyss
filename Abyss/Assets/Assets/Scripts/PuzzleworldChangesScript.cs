using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleworldChangesScript : MonoBehaviour
{
    public NotebookScript notebook;
    public GameObject WorldObject1;
    public GameObject WorldObject2;
    public GameObject WorldObject3;
    public GameObject WorldObject4;
    public GameObject WorldObject5;
    public GameObject WorldObject6;
    public GameObject book;
    private Sprite[] PageSprites;
    private Sprite[] NotebookSprites;
    public GameObject WorldObject7;
    public MonsterMovement MonsterMovement;


    // all refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello    


    void Awake()
    {
        PageSprites = Resources.LoadAll<Sprite>("update pages");
        NotebookSprites = Resources.LoadAll<Sprite>("Pagespage");

    }

    private void Start()
    {
        LoadNewGame();
    }

    //undo all changes for new new game and hides game objects that need to be hidden 
    public void LoadNewGame()
    {
       
        Debug.Log("load new game started");
        
        notebook.ChangePageImage(NotebookSprites[3], 3);
        notebook.ChangePageImage(NotebookSprites[4], 4);
        WorldObject2.gameObject.SetActive(false);
        WorldObject3.gameObject.SetActive(false);
        WorldObject4.SetActive(false);
        WorldObject1.SetActive(true);
        Sprite ObjectChange = WorldObject1.GetComponent<Sprite>();
        WorldObject5.SetActive(true);
        WorldObject6.SetActive(true);
        notebook.ChangePageImage(Resources.Load<Sprite>("dogPage"), 9);
        WorldObject7.SetActive(false);
    }

    public void Effect0()
    {
        notebook.ChangePageImage(PageSprites[0],2);
        Debug.Log("hewwo");
    }

    public void Effect10()
    {
        
        notebook.ChangePageImage(PageSprites[1], 3);
    }

    public void Effect15()
    {
        Debug.Log("Effect15 called");
        WorldObject1.SetActive(false);
    }

    public void Effect20()
    {
        WorldObject2.SetActive(true);
    }
    public void Effect30()
    {
        WorldObject3.SetActive(true);
    }

    public void Effect40()
    {
        Sprite image = Resources.Load<Sprite>("dogPage2");
        notebook.ChangePageImage(image, 9);
    }

    public void Effect60()
    {
        WorldObject4.SetActive(true);
        WorldObject5.SetActive(false);
        WorldObject6.SetActive(false);
    }

    public void Effect70()
    {
        MonsterMovement.StopMonster();
        WorldObject7.SetActive(true);
    }

}




