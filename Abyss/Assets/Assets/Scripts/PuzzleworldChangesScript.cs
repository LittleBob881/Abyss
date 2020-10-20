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
    // all refence and names are in code please refer to Puzzles.doc  


    void Start()
    {
        WorldObject2.gameObject.SetActive(false);
        WorldObject3.gameObject.SetActive(false);
    }

    public void Effect0()
    {
        Sprite image = Resources.Load<Sprite>("update page1");
        notebook.ChangePageImage(image,3);
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
        WorldObject2.SetActive(false);
    }
    public void Effect30()
    {
        WorldObject3.SetActive(false);
    }






}




