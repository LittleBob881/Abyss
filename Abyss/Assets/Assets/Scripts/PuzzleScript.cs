using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class PuzzleScript : MonoBehaviour
    {

        private static PuzzleRefeanceItems puzzleMaster;
        private static int PuzzleItemValue;
        private static int PuzzleValue;

       
        void Start()
        {

        }

        


        
        
        
        public int GetPuzzleItemValue()
        {
            return PuzzleItemValue;
        }

        public int GetPuzzleValue()
        {
            return PuzzleValue;
        }

        public class PuzzleRefeanceItems
        {
            inventoryScript.inventory puzzleInventory;
            //add story array here 


            public PuzzleRefeanceItems()
            {
                puzzleInventory = new inventoryScript.inventory();
                Sprite[] sprites = Resources.LoadAll<Sprite>("itemsheet_7");
                inventoryScript.inventoryItem Empty = new inventoryScript.inventoryItem("Empty", 0, sprites[0], sprites[0]);
                inventoryScript.inventoryItem item1 = new inventoryScript.inventoryItem("bone", 1, sprites[1], sprites[13]);
                inventoryScript.inventoryItem item2 = new inventoryScript.inventoryItem("pen", 2, sprites[2], sprites[14]);
                inventoryScript.inventoryItem item3 = new inventoryScript.inventoryItem("tomato", 3, sprites[3], sprites[15]);
                inventoryScript.inventoryItem item4 = new inventoryScript.inventoryItem("onion", 4, sprites[4], sprites[16]);
                inventoryScript.inventoryItem item5 = new inventoryScript.inventoryItem("crayon", 5, sprites[5], sprites[17]);
                inventoryScript.inventoryItem item6 = new inventoryScript.inventoryItem("key", 6, sprites[6], sprites[18]);
                inventoryScript.inventoryItem item7 = new inventoryScript.inventoryItem("coffee", 7, sprites[7], sprites[19]);
                inventoryScript.inventoryItem item8 = new inventoryScript.inventoryItem("money", 8, sprites[8], sprites[20]);
                inventoryScript.inventoryItem item9 = new inventoryScript.inventoryItem("whisky", 9, sprites[9], sprites[21]);
                inventoryScript.inventoryItem item10 = new inventoryScript.inventoryItem("knife", 10, sprites[10], sprites[22]);
                inventoryScript.inventoryItem item11 = new inventoryScript.inventoryItem("posion", 11, sprites[11], sprites[23]);
                inventoryScript.inventoryItem item12 = new inventoryScript.inventoryItem("hammer", 12, sprites[12], sprites[24]);
           



                puzzleInventory.addInventoryItem(Empty);
                puzzleInventory.addInventoryItem(item1);
                puzzleInventory.addInventoryItem(item2);
                puzzleInventory.addInventoryItem(item3);
                puzzleInventory.addInventoryItem(item4);
                puzzleInventory.addInventoryItem(item5);
                puzzleInventory.addInventoryItem(item6);
                puzzleInventory.addInventoryItem(item7);
                puzzleInventory.addInventoryItem(item8);
                puzzleInventory.addInventoryItem(item9);
                puzzleInventory.addInventoryItem(item10);
                puzzleInventory.addInventoryItem(item11);
                puzzleInventory.addInventoryItem(item12);
                
            }


            public inventoryScript.inventory GetPuzzleInventory()
            {
                return puzzleInventory;
            }
        }
    }
