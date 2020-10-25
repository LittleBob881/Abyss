using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PuzzleScript : MonoBehaviour
{

    private static PuzzleRefeanceItems puzzleMaster;
    private static int PuzzleItemProgress;
    private Boolean[] Unlocks;
    private PuzzleItemCompareIndex PICIndex;
    public inventoryScript InventoryScript;
    public PuzzleworldChangesScript changesScript;
    public MenuLoadscript MainMenu;
    


    // enum varibles  

    //Inventory items
    public static int BONE = 6;
    public static int PEN = 4;
    public static int TOMATO = 0;
    public static int ONION = 1;
    public static int CRAYON = 5;
    public static int COFFEE = 2;
    public static int KNIFE = 8;
    public static int POISON = 3;
    public static int HAMMER = 7;
    //Room items
    public static int POT = 0;
    public static int TOYDOG = 7;
    public static int PAPER = 4;
    public static int PAINTINGMOTHER = 2;
    public static int PAINTINGPLAYER = 8;
    public static int PAINTINGGIRL = 5;
    public static int DOGHOUSE = 6;

    //unlocks
    //in code so everything not reveled
    // all refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello 
    public static int TAP = 0;
    public static int OAP = 1;
    public static int PC = 2;
    public static int CUOM = 3;
    public static int PUOM = 4;
    public static int MK = 5;
    public static int PUOP = 6;
    public static int CUOC = 7;
    public static int CHC = 8;
    public static int BUOD = 9;
    public static int HUOT = 10;
    public static int DK = 11;
    public static int KUOP = 12;

    // Awake is called when the script is first being loaded 
    // first intualises all the variables
    void Awake()
    {
        PuzzleItemProgress = 0;
        PICIndex = new PuzzleItemCompareIndex();
        Unlocks = new Boolean[13];
        Unlocks[TAP] = false;
        Unlocks[OAP] = false;
        Unlocks[PC] = false;
        Unlocks[CUOM] = false;
        Unlocks[PUOM] = false;
        Unlocks[MK] = false;
        Unlocks[PUOP] = false;
        Unlocks[CUOC] = false;
        Unlocks[CHC] = false;
        Unlocks[BUOD] = false;
        Unlocks[HUOT] = false;
        Unlocks[DK] = false;
        Unlocks[KUOP] = false;
    }

    // is called before update()
    void Start()
    {
        if(MainMenu.loadContinue)
        {
            LoadPuzzleSave();
        }
    }

    // sets puzzle progress to 0
    // sets all unlocks to false
    // resets all the changes to world scene
    public void NewGame()
    {
        PuzzleItemProgress = 0;
        Unlocks[TAP] = false;
        Unlocks[OAP] = false;
        Unlocks[PC] = false;
        Unlocks[CUOM] = false;
        Unlocks[PUOM] = false;
        Unlocks[MK] = false;
        Unlocks[PUOP] = false;
        Unlocks[CUOC] = false;
        Unlocks[CHC] = false;
        Unlocks[BUOD] = false;
        Unlocks[HUOT] = false;
        Unlocks[DK] = false;
        Unlocks[KUOP] = false;
        changesScript.LoadNewGame();

    }

    //resets the world and if there is save data load the save
    public void Tryagain()
    {
        NewGame();

        //if there is save data 
        // LoadPuzzleSave();


    }
    public void LoadPuzzleSave()
    {
        
        //call load here?
        // add in PuzzleItemProgress = save;
        // add in Unlocks[] = saveUnlocks[];
        PuzzleItemProgression();
    }

    // checks if the right room item is pressed and if the player has the by itemPuzzleProgress stage
    // returns a bool dependent if an item is used or not.
    // for refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello 
    public Boolean ActiveItemPuzzleCheck(int RoomItemID, int ActiveItemID)
    {
        Boolean ItemUsed = false;
        
        
    
        if (PuzzleItemProgress == 0)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(POT))
            {
                if (ActiveItemID == PICIndex.getItemIndex(TOMATO))
                {
                    Unlocks[TAP] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(3);
                }
                else if (ActiveItemID == PICIndex.getItemIndex(ONION))
                {
                    Unlocks[OAP] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(4);
                }

            }

        }
        else if (PuzzleItemProgress == 10)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGMOTHER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(COFFEE))
                {
                    Unlocks[CUOM] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(7);
                }

            }
        }
        else if (PuzzleItemProgress ==15)
        {
            if (ActiveItemID == PICIndex.getItemIndex(POISON))
            {
                Unlocks[PUOM] = true;
                ItemUsed = true;
                InventoryScript.RemoveItemFromInventory(11);
            }
        }
        else if (PuzzleItemProgress == 20)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAPER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(PEN))
                {
                    Unlocks[PUOP] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(2);
                }
            }
        }
        else if (PuzzleItemProgress == 30)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGGIRL))
            {
                if (ActiveItemID == PICIndex.getItemIndex(CRAYON))
                {
                    Unlocks[CUOC] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(5);
                }
            }

        }
        else if (PuzzleItemProgress == 40)
        {
            if (RoomItemID == PICIndex.getRoomItemIndex(DOGHOUSE))
            {
                if (ActiveItemID == PICIndex.getItemIndex(BONE))
                {
                    Unlocks[BUOD] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(1);
                }
            }

        }
        else if (PuzzleItemProgress == 50)
        {

            if (RoomItemID == PICIndex.getRoomItemIndex(TOYDOG))
            {
                if (ActiveItemID == PICIndex.getItemIndex(HAMMER))
                {
                    Unlocks[HUOT] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(12);
                }
            }
        }
        else if (PuzzleItemProgress == 60)
        {

            if (RoomItemID == PICIndex.getRoomItemIndex(PAINTINGPLAYER))
            {
                if (ActiveItemID == PICIndex.getItemIndex(KNIFE))
                {
                    Unlocks[KUOP] = true;
                    ItemUsed = true;
                    InventoryScript.RemoveItemFromInventory(10);
                }
            }
        }

        PuzzleItemProgression();

        return ItemUsed;
    }


    // Checks the progress to see if thinks need to be unlocked.
    // all refence and names are in code please refer to Puzzles.doc on the Abyss google share drive or Abyss trello 
    // need to be called for load game
    void PuzzleItemProgression()
    {
        if(PuzzleItemProgress == 0 &&(Unlocks[TAP]==true&&Unlocks[OAP]==true))
        {

            Unlocks[PC] = true;
            PuzzleItemProgress = 10;
            changesScript.Effect0();
        }
        if(PuzzleItemProgress == 10 && (Unlocks[CUOM] == true))
        {
            PuzzleItemProgress = 15;
            changesScript.Effect10();
        }
        if (PuzzleItemProgress == 15 && (Unlocks[PUOM] == true))
        {
            Unlocks[MK] = true;
            PuzzleItemProgress = 20;
            changesScript.Effect15();
        }
        if (PuzzleItemProgress == 20 && (Unlocks[PUOP] == true))
        {
            
            PuzzleItemProgress = 30;
            changesScript.Effect20();
        }
        if (PuzzleItemProgress == 30 && (Unlocks[CUOC] == true))
        {
            Unlocks[CHC] = true;
            PuzzleItemProgress = 40;
            changesScript.Effect30();
        }
        if (PuzzleItemProgress == 40 && (Unlocks[BUOD] == true))
        {

            PuzzleItemProgress = 50;
            changesScript.Effect40();
        }
        if (PuzzleItemProgress == 50 && (Unlocks[HUOT] == true))
        {
            Unlocks[DK] = true;
            PuzzleItemProgress = 60;
            //Add effect unlock
        }
        if (PuzzleItemProgress == 60 && (Unlocks[KUOP] == true))
        {

            PuzzleItemProgress = 70;
            changesScript.Effect60();
        }
        if (PuzzleItemProgress == 70)
        {
            changesScript.Effect70();
        }
    }


    public Boolean ItemlockedCheck(int ItemId)
    {
        Boolean toreturn = false;
        
        if (PuzzleItemProgress == 0)
        {
            if(Unlocks[PC] == false )
            {
                if(ItemId == 3)
                {
                    if(Unlocks[TAP] == false)
                    {
                        // if at PuzzleItemProgress 0 
                        // and PC is false
                        //and itemId is tomato 
                        //and tomato has not been used 
                        //then return true. 
                        toreturn = true;
                    }
                }
                else if(ItemId == 4)
                {
                    if (Unlocks[OAP] == false)
                    {
                        // same as tomato but for onion.
                        toreturn = true;
                    }
                }
            }
        }

        if (PuzzleItemProgress == 10)
        {
             if (ItemId == 7)
             {
                if (Unlocks[CUOM] == false)
                {
                    // if at PuzzleItemProgress 10 
                    //and itemId is Coffee's 
                    //and coffee has not been used 
                    //then return true. 
                    toreturn = true;
                }
             }
        }

        if (PuzzleItemProgress == 15)
        {
            if (ItemId == 11)
            {
                if (Unlocks[PUOM] == false)
                {
                    // if at PuzzleItemProgress 15 
                    //and itemId is Poison's 
                    //and poison has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        if (PuzzleItemProgress == 20)
        {
            if (ItemId == 2)
            {
                if (Unlocks[PUOP] == false)
                {
                    // if at PuzzleItemProgress 20 
                    //and itemId is Pen's 
                    //and pen has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }

        if (PuzzleItemProgress == 30)
        {
            if (ItemId == 5)
            {
                if (Unlocks[CUOC] == false)
                {
                    // if at PuzzleItemProgress 30 
                    //and itemId is Crayon's 
                    //and crayon has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        if (PuzzleItemProgress == 40)
        {
            if (ItemId == 1)
            {
                if (Unlocks[BUOD] == false)
                {
                    // if at PuzzleItemProgress 40
                    //and itemId is bone's 
                    //and Bone has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        if (PuzzleItemProgress == 50)
        {
            if (ItemId == 12)
            {
                if (Unlocks[HUOT] == false)
                {
                    // if at PuzzleItemProgress 50 
                    //and itemId is Hammer's 
                    //and hammer has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        if (PuzzleItemProgress == 60)
        {
            if (ItemId == 10)
            {
                if (Unlocks[KUOP] == false)
                {
                    // if at PuzzleItemProgress 60 
                    //and itemId is Kife's 
                    //and Kinfe has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        if (PuzzleItemProgress == 70)
        {
            if (ItemId == 8)
            {
                if (Unlocks[KUOP] == true)
                {
                    // if at PuzzleItemProgress 60 
                    //and itemId is money's 
                    //and Kinfe has not been used 
                    //then return true. 
                    toreturn = true;
                }
            }
        }
        return toreturn;
    }




    // gets

    public int GetPuzzleItemValue()
    {
        return PuzzleItemProgress;
    }



    public Boolean[] GetUnlock()
    {
        return Unlocks;
    }


      public class PuzzleRefeanceItems
      {
            inventoryScript.inventory puzzleInventory;

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
