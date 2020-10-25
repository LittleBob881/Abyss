using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureScript : MonoBehaviour
{

    public Button[] Unitybutton;
    private RoomItem[] roomitems;
    public inventoryScript invenScript;
    private PuzzleScript.PuzzleRefeanceItems list;
    public GameObject speechbox;
    public PuzzleScript PuzzleScript;
    private int PuzzleProgressNeedForSaveChecker;

    void Awake()
    {
        Debug.Log("Start fruriture script");
        
        list = new PuzzleScript.PuzzleRefeanceItems();
        CreateButtons();
        AddRoomItems();
        PuzzleProgressNeedForSaveChecker = 0;
    }

    // please refuer to RoomItem.doc on Google drive or Trello 
    // action when roomItem button pressed
    // num = item number
    // calls room item action
    private void OnClick0()
    {
        int RoomitemID = 0;
        RoomItemAction(RoomitemID);
    }

    private void OnClick1()
    {
        int RoomItemID = 1;
        RoomItemAction(RoomItemID);
    }

    private void OnClick2()
    {
        int RoomItemID = 2;
        RoomItemAction(RoomItemID);
    }

    private void OnClick3()
    {
        int RoomItemID = 3;
        RoomItemAction(RoomItemID);
    }

    private void OnClick4()
    {
        int RoomItemID = 4;
        RoomItemAction(RoomItemID);
    }

    private void OnClick5()
    {
        int RoomItemID = 5;
        RoomItemAction(RoomItemID);
    }

    private void OnClick6()
    {
        int RoomItemID = 6;
        RoomItemAction(RoomItemID);
    }

    private void OnClick7()
    {
        int RoomItemID = 7;
        RoomItemAction(RoomItemID);
    }

    private void OnClick8()
    {
        int RoomItemID = 8;
        RoomItemAction(RoomItemID);
    }

    private void OnClick9()
    {
        int num = 9;
        RoomItemAction(num);
    }

    private void OnClick10()
    {
        int num = 10;
        RoomItemAction(num);
    }

    private void OnClick11()
    {
        int num = 11;
        RoomItemAction(num);
    }

    private void OnClick12()
    {
        int num = 12;
        RoomItemAction(num);
    }

    //Mirror 
    private void OnClick13()
    {
        MirrorAction();
    }

    private void OnClick14()
    {
        int num = 14;
        RoomItemAction(num);
    }

    private void OnClick15()
    {
        int num = 15;
        RoomItemAction(num);
    }

    private void OnClick16()
    {
        int num = 16;
        RoomItemAction(num);
    }

    private void OnClick17()
    {
        int num = 17;
        RoomItemAction(num);
    }

    private void OnClick18()
    {
        int num = 18;
        RoomItemAction(num);
    }

    private void OnClick19()
    {
        int num = 19;
        RoomItemAction(num);
    }

    private void OnClick20()
    {
        int num = 20;
        RoomItemAction(num);
    }

    private void OnClick21()
    {
        int num = 21;
        RoomItemAction(num);
    }

    private void OnClick22()
    {
        int num = 22;
        RoomItemAction(num);
    }

    private void OnClick23()
    {
        int num = 23;
        RoomItemAction(num);
    }
    
    private void OnClick24()
    {
        int num = 24;
        RoomItemAction(num);
    }

    private void OnClick25()
    {
        int num = 25;
        RoomItemAction(num);
    }

    private void OnClick26()
    {
        int num = 26;
        RoomItemAction(num);
    }


    //action if a room item is pressed 
    // checks if an invetory item is active in inventory.
    //      if there is an active item, it sends room item ID and active item ID with the useActiveItem fuction.
    // if there is no active item then ViewItemSpeech is called which updates the speech game object with the string discribing the roomItem.
    // if there is an item to pick up then the item is placed in the inventory and the speech box is updated to say what item was picked up. 
    public void RoomItemAction(int RoomItemID)
    {
        Debug.Log("starting room item action ");

        if (invenScript.GetPlayerInventory().getActiveItemID() != 0)
        {
            UseActiveItem(RoomItemID, invenScript.GetPlayerInventory().getActiveItemID());
        }
        else
        {
            ViewItemSpeech(RoomItemID);

            PickupItemCheck(RoomItemID);
        }

    }


    //if there is an item to pick up then the item is placed in the inventory and the speech box is updated to say what item was picked up.
    //checks if item is unlocked and is able to be picked up. 
    private void PickupItemCheck(int RoomItemID)
    {
        int itemID = roomitems[RoomItemID].GetItem();
        if (itemID != 0)
        {
            if (PuzzleScript.ItemlockedCheck(itemID))
            {
                // adds item to inventory
                bool AddedItemBool = invenScript.GetPlayerInventory().PickupItem(list.GetPuzzleInventory().getInventorySlot(itemID));
                if (AddedItemBool == true)
                {
                    AddItemSpeech(RoomItemID);
                }
            }

        }
    }

    // sets the speech box string to the string from the first string in the string array from the seleceted roomItem
    void ViewItemSpeech(int RoomItemID)
    {
        Text speech = speechbox.GetComponent<Text>();
        roomitems[RoomItemID].SetOutput(0);
        String strings = roomitems[RoomItemID].GetOutput();
        speech.text = strings;
    }

    // sets the speech box to the a string that says the player picked up name of item. 
        public void AddItemSpeech(int RoomItemID)
    {
        Text speech = speechbox.GetComponent<Text>();
        String strings = "Picked up " + list.GetPuzzleInventory().getInventorySlot(roomitems[RoomItemID].GetItem()).getName();
        speech.text = strings;
    }


    // itemUsed checks if the right item is being added to the right room object
    // if it is the wrong item then sets the speech box to the a string that says that item name doesnt go here.
    // if it is the right item then it sets the speech box to the a string that says that item name was used on roomitem name 
    void UseActiveItem(int RoomItemID,int ActiveItemID )
    {
        String ActiveItemName = invenScript.GetPlayerInventory().getActiveItemName();
        Boolean ItemUsed = PuzzleScript.ActiveItemPuzzleCheck(RoomItemID,ActiveItemID);
        String ItemActionString = " ";
        if(ItemUsed == false)
        {
            Debug.Log("useactive item:" +invenScript.GetPlayerInventory().getActiveItemID());
            ItemActionString = ActiveItemName + " doesn't seem to go here";
        }
        else
        {
            ItemActionString = ActiveItemName + " used on " + roomitems[RoomItemID].GetName();
        }

        Text speech = speechbox.GetComponent<Text>();
        speech.text = ItemActionString;

    }

    // save fuction for mirror 
    void MirrorAction()
    {
        String MirrorActionString= " ";
        if (PuzzleScript.GetPuzzleItemValue() != PuzzleProgressNeedForSaveChecker )
        {
            // save data 

            MirrorActionString = "Progress saved";
            PuzzleProgressNeedForSaveChecker = PuzzleScript.GetPuzzleItemValue();
        }
        else
        {
            MirrorActionString = "Looks like I can save my Progress here";
        }



        Text speech = speechbox.GetComponent<Text>();
        speech.text = MirrorActionString;
    }

    //create all 27 roomitems and fills with data
    void AddRoomItems()
    {
        roomitems = new RoomItem[27];
        string[] Strings0 = { "Chair for a child" };
        string[] Strings1 = { "Its a table", "There is a recipe on the table, added to notebook." };
        string[] Strings2 = { "Its an oven", "Its hot." };
        string[] Strings3 = { "Its a very large pot", "Added tomato to pot" };
        string[] Strings4 = { "There is nothing interesting in here" };
        string[] Strings5 = { "Its chilly in here", "There is a tomato here, added to inventory" };
        string[] Strings6 = { "There is nothing interesting in here." };
        string[] Strings7 = { "I don’t feel like sleeping currently" };
        string[] Strings8 = { "It’s a toy dog" };
        string[] Strings9 = { "This seems like it’s many years old, but it also seems brand new." };
        string[] Strings10 = { "Its empty" };
        string[] Strings11 = { "It’s a piece of paper stuck to the wall" };
        string[] Strings12 = { "It looks like I could hide here" };
        string[] Strings13 = { "A mirror for saving" };
        string[] Strings14 = { "It’s a painting of a woman " };
        string[] Strings15 = { "It’s a safe, I wonder what’s inside " };
        string[] Strings16 = { "Is this a painting of me?" };
        string[] Strings17 = { "It’s a painting of a young girl" };
        string[] Strings18 = { "It’s a veggie garden" };
        string[] Strings19 = { "Its an old tree" };
        string[] Strings20 = { "I don’t see a dog" };
        string[] Strings21 = { "A box of old tools and junk" };
        string[] Strings22 = { "Its is displaying random junk " };
        string[] Strings23 = { "Ugh exercise " };
        string[] Strings24 = { "It’s a tv, it doesn’t seem to work though." };
        string[] Strings25 = { "It looks soft to sit on. " };
        string[] Strings26 = { "It looks like I could hide here" };


        roomitems[0] = new RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[1] = new RoomItem("Kitchen", "Table", Strings1, 0, 0);
        roomitems[2] = (new RoomItem("Kitchen", "Oven", Strings2, 0, 0));
        roomitems[3] = (new RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[4] = (new RoomItem("Kitchen", "Sink", Strings4, 0, 0));

        roomitems[5] = new RoomItem("Kitchen", "Fridge", Strings5, 3, 0);
        roomitems[6] = new RoomItem("Kitchen", "Sink", Strings6, 11, 2);
        roomitems[7] = (new RoomItem("Kitchen", "Bed", Strings7, 1, 0));
        roomitems[8] = (new RoomItem("Kitchen", "Toy dog ", Strings8, 0, 0));
        roomitems[9] = (new RoomItem("Kitchen", "Side table", Strings9, 0, 0));

        roomitems[10] = new RoomItem("Kitchen", "Cupboard", Strings10, 5, 0);
        roomitems[11] = new RoomItem("Kitchen", "Paper", Strings11, 0, 0);
        roomitems[12] = (new RoomItem("Kitchen", "Closet", Strings12, 0, 0));
        roomitems[13] = (new RoomItem("Kitchen", "Mirror", Strings13, 0, 0));
        roomitems[14] = (new RoomItem("Kitchen", "Painting of Mother", Strings14, 0, 0));

        roomitems[15] = new RoomItem("Kitchen", "Safe", Strings15, 8, 0);
        roomitems[16] = new RoomItem("Kitchen", "Painting of Frank", Strings16, 0, 0);
        roomitems[17] = (new RoomItem("Kitchen", "Painting of little girl", Strings17, 0, 0));
        roomitems[18] = (new RoomItem("Kitchen", "Garden", Strings18, 4, 0));
        roomitems[19] = (new RoomItem("Kitchen", "Tree", Strings19, 7, 0));

        roomitems[20] = new RoomItem("Kitchen", "Dog house", Strings20, 0, 0);
        roomitems[21] = new RoomItem("Kitchen", "Old Tools", Strings21, 12, 0);
        roomitems[22] = (new RoomItem("Kitchen", "Shelf", Strings22, 0, 0));
        roomitems[23] = (new RoomItem("Kitchen", "Treadmill", Strings23, 0, 0));
        roomitems[24] = (new RoomItem("Kitchen", "Tv", Strings24, 10, 0));

        roomitems[25] = new RoomItem("Kitchen", "Couch", Strings25, 2, 0);
        roomitems[26] = new RoomItem("Kitchen", "Closet", Strings26, 0, 0);
        
        
    }

    // adds all buttions with an action listener that call a unique fuction. 
    void CreateButtons()
    {
        Button Roomitem0 = Unitybutton[0].GetComponent<Button>();
        Roomitem0.onClick.AddListener(OnClick0);

        Button Roomitem1 = Unitybutton[1].GetComponent<Button>();
        Roomitem1.onClick.AddListener(OnClick1);

        Button Roomitem2 = Unitybutton[2].GetComponent<Button>();
        Roomitem2.onClick.AddListener(OnClick2);

        Button Roomitem3 = Unitybutton[3].GetComponent<Button>();
        Roomitem3.onClick.AddListener(OnClick3);

        Button Roomitem4 = Unitybutton[4].GetComponent<Button>();
        Roomitem4.onClick.AddListener(OnClick4);

        Button Roomitem5 = Unitybutton[5].GetComponent<Button>();
        Roomitem5.onClick.AddListener(OnClick5);
        
        Button Roomitem6 = Unitybutton[6].GetComponent<Button>();
        Roomitem6.onClick.AddListener(OnClick6);

        Button Roomitem7 = Unitybutton[7].GetComponent<Button>();
        Roomitem7.onClick.AddListener(OnClick7);

        Button Roomitem8 = Unitybutton[8].GetComponent<Button>();
        Roomitem8.onClick.AddListener(OnClick8);
        
        Button Roomitem9 = Unitybutton[9].GetComponent<Button>();
        Roomitem9.onClick.AddListener(OnClick9);

        Button Roomitem10 = Unitybutton[10].GetComponent<Button>();
        Roomitem10.onClick.AddListener(OnClick10);

        Button Roomitem11 = Unitybutton[11].GetComponent<Button>();
        Roomitem11.onClick.AddListener(OnClick11);

        Button Roomitem12 = Unitybutton[12].GetComponent<Button>();
        Roomitem12.onClick.AddListener(OnClick12);

        Button Roomitem13 = Unitybutton[13].GetComponent<Button>();
        Roomitem13.onClick.AddListener(OnClick13);

        Button Roomitem14 = Unitybutton[14].GetComponent<Button>();
        Roomitem14.onClick.AddListener(OnClick14);

        Button Roomitem15 = Unitybutton[15].GetComponent<Button>();
        Roomitem15.onClick.AddListener(OnClick15);

        Button Roomitem16 = Unitybutton[16].GetComponent<Button>();
        Roomitem16.onClick.AddListener(OnClick16);

        Button Roomitem17 = Unitybutton[17].GetComponent<Button>();
        Roomitem17.onClick.AddListener(OnClick17);

        Button Roomitem18 = Unitybutton[18].GetComponent<Button>();
        Roomitem18.onClick.AddListener(OnClick18);

        Button Roomitem19 = Unitybutton[19].GetComponent<Button>();
        Roomitem19.onClick.AddListener(OnClick19);

        Button Roomitem20 = Unitybutton[20].GetComponent<Button>();
        Roomitem20.onClick.AddListener(OnClick20);

        Button Roomitem21 = Unitybutton[21].GetComponent<Button>();
        Roomitem21.onClick.AddListener(OnClick21);

        Button Roomitem22 = Unitybutton[22].GetComponent<Button>();
        Roomitem22.onClick.AddListener(OnClick22);

        Button Roomitem23 = Unitybutton[23].GetComponent<Button>();
        Roomitem23.onClick.AddListener(OnClick23);

        Button Roomitem24 = Unitybutton[24].GetComponent<Button>();
        Roomitem24.onClick.AddListener(OnClick24);

        Button Roomitem25 = Unitybutton[25].GetComponent<Button>();
        Roomitem25.onClick.AddListener(OnClick25);

        Button Roomitem26 = Unitybutton[26].GetComponent<Button>();
        Roomitem26.onClick.AddListener(OnClick26);
    }


    public class RoomItem
    {
        private String room;
        private String name;
        private String output;
        private string[] dialog;
        private int item;
        private int page;
        private int dialogNumber;

        public RoomItem(String room, String name, string[] textlines, int item, int page)
        {
            this.room = room;
            this.name = name;
            this.output = "  ";
            this.dialog = textlines;
            this.item = item;
            this.page = page;
            this.dialogNumber = 0;
        }



        public String GetName()
        {
            return name;

        }


        //returns output as a string
        public String GetOutput()
        {
            return this.output;
        }

        // sets output from the diaglog list. int chooses which dialog is used.

        public void SetOutput(int num)
        {
            this.output = dialog[num];
        }


        // returns item (not sure how this will work with the item getting.)
        public int GetItem()
        {
            return item;

        }

        // returns item (not sure how this will work with the page getting.)
        public int GetPage()
        {
            return page;

        }

        // sets the Dialog number. 
        public void SetDialogNum(int num)
        {
            this.dialogNumber = num;
        }
    }
}
