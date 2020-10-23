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
    public GameObject book;
    private Sprite[] PageSprites;
    private Sprite[] NotebookSprites;
   

    // all refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello    


    void Awake()
    {
        //book = GameObject.Find("/world/NoteBook/NoteBookImage");
        //notebook = (NotebookScript)book.GetComponent(typeof(NotebookScript));
        PageSprites = Resources.LoadAll<Sprite>("update pages");
        NotebookSprites = Resources.LoadAll<Sprite>("Pagespage");
      
        LoadNewGame();

    }

    //undo all changes for new new game and hides game objects that need to be hidden 
    private void LoadNewGame()
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

        notebook.ChangePageImage(Resources.Load<Sprite>("dogPage"), 9);

    }

    public void Effect0()
    {
        notebook.ChangePageImage(PageSprites[0],3);
        Debug.Log("hewwo");
    }

    public void Effect10()
    {
        
        notebook.ChangePageImage(PageSprites[1], 4);
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
    }




}




