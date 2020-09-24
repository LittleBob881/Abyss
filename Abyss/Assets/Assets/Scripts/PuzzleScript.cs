using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{

    private static PuzzleRefeanceItems puzzleMaster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class PuzzleRefeanceItems
    {
        inventoryScript.inventory puzzleInventory;
        //add story array here 


        public PuzzleRefeanceItems()
        {
            puzzleInventory = new inventoryScript.inventory();
            Sprite[] sprites= Resources.LoadAll<Sprite>("itemsheet_6");
            inventoryScript.inventoryItem Empty = new inventoryScript.inventoryItem(0, sprites[0], sprites[0]);
            inventoryScript.inventoryItem item1 = new inventoryScript.inventoryItem(1, sprites[1], sprites[2]);
            inventoryScript.inventoryItem item2 = new inventoryScript.inventoryItem(2, sprites[3], sprites[4]);
            inventoryScript.inventoryItem item3 = new inventoryScript.inventoryItem(3, sprites[5], sprites[6]);
            inventoryScript.inventoryItem item4 = new inventoryScript.inventoryItem(4, sprites[7], sprites[8]);
            inventoryScript.inventoryItem item5 = new inventoryScript.inventoryItem(5, sprites[9], sprites[10]);
            inventoryScript.inventoryItem item6 = new inventoryScript.inventoryItem(6, sprites[11], sprites[12]);

            puzzleInventory.addInventoryItem(Empty);
            puzzleInventory.addInventoryItem(item1);
            puzzleInventory.addInventoryItem(item2);
            puzzleInventory.addInventoryItem(item3);
            puzzleInventory.addInventoryItem(item4);
            puzzleInventory.addInventoryItem(item5);
            puzzleInventory.addInventoryItem(item6);
        }


        public inventoryScript.inventory GetPuzzleInventory()
        {
            return puzzleInventory;
        }
    }
    }
