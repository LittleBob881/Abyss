using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PuzzleScript : MonoBehaviour
{

    private static PuzzleRefeanceItems puzzleMaster;
    private static int PuzzleItemProgress;
    private static int PuzzleProgress;
    private Boolean[] Unlocks;
    private PuzzleItemCompareIndex PICIndex;


    // vairbles 
    
    public static int BONE = 6;
    public static int PEN = 4;
    public static int TOMATO = 0;
    public static int ONION = 1;
    public static int CRAYON = 5;
    public static int COFFEE = 2;
    public static int KNIFE = 8;
    public static int POISON = 3;
    public static int HAMMER = 7;
    public static int POT = 0;
    public static int TOYDOG = 7;
    public static int PAPER = 4;
    public static int PAINTINGMOTHER = 2;
    public static int PAINTINGPLAYER = 8;
    public static int PAINTINGGIRL = 5;
    public static int DOGHOUSE = 6;


    void Start()
    {
        PuzzleItemProgress = 0;
        PICIndex = new PuzzleItemCompareIndex();
    }





    // checks if the right room item is pressed and if the player has the by itemPuzzleProgress stage 
    public void ActiveItemPuzzleCheack(int RoomItemID, int ActiveItemID)
    {
        if (PuzzleItemProgress == 0)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(POT))
            {
                if (ActiveItemID == PICIndex.getItemIndex(TOMATO))
                {

                }
                else if (ActiveItemID == PICIndex.getItemIndex(ONION))
                {

                }

            }

        }
        else if (PuzzleItemProgress == 2)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGMOTHER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(COFFEE))
                {

                }
                else if (ActiveItemID == PICIndex.getItemIndex(POISON))
                {

                }
            }
        }
        else if (PuzzleItemProgress == 3)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAPER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(PEN))
                {

                }

            }
        }
        else if (PuzzleItemProgress == 4)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGGIRL))
            {
                if (ActiveItemID == PICIndex.getItemIndex(CRAYON))
                {

                }

            }

        }
        else if (PuzzleItemProgress == 5)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(DOGHOUSE))
            {
                if (ActiveItemID == PICIndex.getItemIndex(BONE))
                {

                }

            }

        }
        else if (PuzzleItemProgress == 6)
        {

            if (RoomItemID == PICIndex.getRoomItemIndex(TOYDOG))
            {
                if (ActiveItemID == PICIndex.getItemIndex(HAMMER))
                {

                }

            }
        }
        else if (PuzzleItemProgress == 7)
        {

            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGPLAYER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(KNIFE))
                {

                }

            }
        }
    }


    // gets

    public int GetPuzzleItemValue()
    {
        return PuzzleItemProgress;
    }

    public int GetPuzzleValue()
    {
        return PuzzleProgress;
    }

    public Boolean[] GetUnlock()
    {
        return Unlocks;
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
                inventoryScript.inventoryItem item11 = new inventoryScript.inventoryItem("poison", 11, sprites[11], sprites[23]);
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


    public class PuzzleItemCompareIndex
    {
        int[] ItemIndex;
        int[] RoomItemIndex;

        public PuzzleItemCompareIndex()
        {
            ItemIndex = new int[9];
            ItemIndex[0] = 3;
            ItemIndex[1] = 4;
            ItemIndex[2] = 7;
            ItemIndex[3] = 11;
            ItemIndex[4] = 2;
            ItemIndex[5] = 5;
            ItemIndex[6] = 1;
            ItemIndex[7] = 12;
            ItemIndex[8] = 10;

            RoomItemIndex = new int[9];
            RoomItemIndex[0] = 3;
            RoomItemIndex[1] = 3;
            RoomItemIndex[2] = 14;
            RoomItemIndex[3] = 14;
            RoomItemIndex[4] = 11;
            RoomItemIndex[5] = 17;
            RoomItemIndex[6] = 20;
            RoomItemIndex[7] = 8;
            RoomItemIndex[8] = 16;

        }

        public int getRoomItemIndex(int num)
        {
            return RoomItemIndex[num];
        }

        public int getItemIndex(int num)
        {
            return ItemIndex[num];
        }

    }


}
