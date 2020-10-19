using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleworldChangesScript : MonoBehaviour
{
    public NotebookScript notebook;
    public GameObject WorldObject1; 
    // all refence and names are in code please refer to Puzzles.doc  

    
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
        Button ObjectChange = WorldObject1.GetComponent<Button>(); ;
        ObjectChange.image.sprite = Resources.Load<Sprite>("roomitemsheet_2_1");
    }



}




