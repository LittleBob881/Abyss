using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Data;


public class titleScrip : MonoBehaviour
{
    private static inventory playerInventory;
    private static player player;
    private static inventory puzzleInventory;
    private static inventory usedInventory;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("title script ran");




    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void createNewGame()
    {
        playerInventory = new inventory();
        puzzleInventory = new inventory();
        usedInventory = new inventory();

    }

}
