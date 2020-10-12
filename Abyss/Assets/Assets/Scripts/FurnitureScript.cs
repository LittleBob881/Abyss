﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureScript : MonoBehaviour
{

    public Button[] Unitybutton;
    private AbyssLibrary.RoomItem[] roomitems;
    public inventoryScript invenScript;
    private PuzzleScript.PuzzleRefeanceItems list;
    public GameObject speechbox;
    public PuzzleScript PuzzleScript;

    void Start()
    {
        Debug.Log("Start fruriture script");
        
        list = new PuzzleScript.PuzzleRefeanceItems();
        CreateButtons();
        AddRoomItems();
    }


    // action when roomItem button pressed
    // num = item number
    // calls room item action
    private void OnClick0()
    {
        int num = 0;
        RoomItemAction(num);
    }

    private void OnClick1()
    {
        int num = 1;
        RoomItemAction(num);
    }

    private void OnClick2()
    {
        int num = 2;
        RoomItemAction(num);
    }

    private void OnClick3()
    {
        int num = 3;
        RoomItemAction(num);
    }

    private void OnClick4()
    {
        int num = 4;
        RoomItemAction(num);
    }

    private void OnClick5()
    {
        int num = 5;
        RoomItemAction(num);
    }

    private void OnClick6()
    {
        int num = 6;
        RoomItemAction(num);
    }

    private void OnClick7()
    {
        int num = 7;
        RoomItemAction(num);
    }

    private void OnClick8()
    {
        int num = 8;
        RoomItemAction(num);
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

    private void OnClick13()
    {
        int num = 13;
        RoomItemAction(num);
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


    
    public void RoomItemAction(int num)
    {

        if (invenScript.GetPlayerInventory().getActiveItemID() != 0)
        {

        }
        else
        {
            ViewItemSpeech(num);

            if (roomitems[num].GetItem() != 0)
            {

                bool AddedItemBool = invenScript.GetPlayerInventory().PickupItem(list.GetPuzzleInventory().getInventorySlot(roomitems[num].GetItem()));
                if (AddedItemBool == true)
                {
                    AddItemSpeech(num);
                }

            }
        }

    }

    void ViewItemSpeech(int num)
    {
        Text speech = speechbox.GetComponent<Text>();
        String[] strings = roomitems[num].getStrings();
        speech.text = strings[0];
    }
        public void AddItemSpeech(int num)
    {
        Text speech = speechbox.GetComponent<Text>();
        String strings = "Picked up " + list.GetPuzzleInventory().getInventorySlot(roomitems[num].GetItem()).getName();
        speech.text = strings;
    }


    void UseActiveItem()
    {

    }

    //create all 27 roomitems and fills with data
    void AddRoomItems()
    {
        roomitems = new AbyssLibrary.RoomItem[27];
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


        roomitems[0] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[1] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 0);
        roomitems[2] = (new AbyssLibrary.RoomItem("Kitchen", "Oven", Strings2, 0, 0));
        roomitems[3] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[4] = (new AbyssLibrary.RoomItem("Kitchen", "Sink", Strings4, 0, 0));

        roomitems[5] = new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings5, 3, 0);
        roomitems[6] = new AbyssLibrary.RoomItem("Kitchen", "Sink", Strings6, 11, 2);
        roomitems[7] = (new AbyssLibrary.RoomItem("Kitchen", "Bed", Strings7, 1, 0));
        roomitems[8] = (new AbyssLibrary.RoomItem("Kitchen", "Toy dog ", Strings8, 0, 0));
        roomitems[9] = (new AbyssLibrary.RoomItem("Kitchen", "Side table", Strings9, 0, 0));

        roomitems[10] = new AbyssLibrary.RoomItem("Kitchen", "Cupboard", Strings10, 5, 0);
        roomitems[11] = new AbyssLibrary.RoomItem("Kitchen", "Paper", Strings11, 0, 0);
        roomitems[12] = (new AbyssLibrary.RoomItem("Kitchen", "Closet", Strings12, 0, 0));
        roomitems[13] = (new AbyssLibrary.RoomItem("Kitchen", "Mirror", Strings13, 0, 0));
        roomitems[14] = (new AbyssLibrary.RoomItem("Kitchen", "Painting of Mother", Strings14, 0, 0));

        roomitems[15] = new AbyssLibrary.RoomItem("Kitchen", "Safe", Strings15, 8, 0);
        roomitems[16] = new AbyssLibrary.RoomItem("Kitchen", "Painting of Frank", Strings16, 0, 0);
        roomitems[17] = (new AbyssLibrary.RoomItem("Kitchen", "Painting of little girl", Strings17, 0, 0));
        roomitems[18] = (new AbyssLibrary.RoomItem("Kitchen", "Garden", Strings18, 4, 0));
        roomitems[19] = (new AbyssLibrary.RoomItem("Kitchen", "Tree", Strings19, 7, 0));

        roomitems[20] = new AbyssLibrary.RoomItem("Kitchen", "Dog house", Strings20, 0, 0);
        roomitems[21] = new AbyssLibrary.RoomItem("Kitchen", "Old Tools", Strings21, 12, 0);
        roomitems[22] = (new AbyssLibrary.RoomItem("Kitchen", "Shelf", Strings22, 0, 0));
        roomitems[23] = (new AbyssLibrary.RoomItem("Kitchen", "Treadmill", Strings23, 0, 0));
        roomitems[24] = (new AbyssLibrary.RoomItem("Kitchen", "Tv", Strings24, 10, 0));

        roomitems[25] = new AbyssLibrary.RoomItem("Kitchen", "Couch", Strings25, 2, 0);
        roomitems[26] = new AbyssLibrary.RoomItem("Kitchen", "CLoset", Strings26, 0, 0);
        
        
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
}
