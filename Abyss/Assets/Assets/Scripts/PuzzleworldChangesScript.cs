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
    public GameObject book;
    private Sprite[] Sprites;

    // all refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello    


    void Awake()
    {
        //book = GameObject.Find("/world/NoteBook/NoteBookImage");
        //notebook = (NotebookScript)book.GetComponent(typeof(NotebookScript));
        Sprites = Resources.LoadAll<Sprite>("update pages");
        LoadNewGame();

    }

    //undo all changes for new new game and hides game objects that need to be hidden 
    private void LoadNewGame()
    {
       
        Debug.Log("load new game started");
        Sprite image = Resources.Load<Sprite>("page3");
        notebook.ChangePageImage(image, 3);
        image = Resources.Load<Sprite>("page4");
        notebook.ChangePageImage(image, 4);
        WorldObject2.gameObject.SetActive(false);
        WorldObject3.gameObject.SetActive(false);
        WorldObject4.SetActive(false);
        WorldObject1.SetActive(true);
        Button ObjectChange = WorldObject1.GetComponent<Button>();
        ObjectChange.image.sprite = Resources.Load<Sprite>("roomitemsheet_2_0");
        image = Resources.Load<Sprite>("dogPage");
        notebook.ChangePageImage(image, 9);

    }

    public void Effect0()
    {
        notebook.ChangePageImage(Sprites[0],3);
        Debug.Log("hewwo");
    }

    public void Effect10()
    {
        Sprite image = Resources.Load<Sprite>("update page2");
        notebook.ChangePageImage(image, 4);
    }

    public void Effect15()
    {
        Button ObjectChange = WorldObject1.GetComponent<Button>(); 
        ObjectChange.image.sprite = Resources.Load<Sprite>("roomitemsheet_2_1");
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
        WorldObject1.SetActive(false);
    }




}




