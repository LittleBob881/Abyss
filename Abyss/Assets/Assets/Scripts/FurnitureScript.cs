using System;
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

    void Start()
    {
        Debug.Log("Start fruriture script");
       
       


        list = new PuzzleScript.PuzzleRefeanceItems();
        loadRoomItems();
    }


    // action when roomItem button pressed
    // num = item number
    // calls room item action
    private void OnClick1()
    {
        int num = 1;
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




    public void RoomItemAction(int num)
    {
        Debug.Log("item button pressed: " +num);

        Text speech = speechbox.GetComponent<Text>();
        String[] strings = roomitems[num].getStrings();
        speech.text = strings[0];
        if (roomitems[num].GetItem() != 0)
        {

            _ = invenScript.GetPlayerInventory().PickupItem(list.GetPuzzleInventory().getInventorySlot(roomitems[num].GetItem()));

        }
    }

     void loadRoomItems()
     {
        roomitems = new AbyssLibrary.RoomItem[27];
        string[] Strings0 = { "Chair for a child", "meh" };
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
        string[] Strings12 = { "It looks like I could hide here" +
                "" };
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
        roomitems[1] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[2] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[3] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[4] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));

        roomitems[5] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[6] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[7] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[8] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[9] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));

        roomitems[10] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[11] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[12] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[13] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[14] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));

        roomitems[15] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[16] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[17] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[18] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[19] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));

        roomitems[20] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[21] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[22] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[23] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[24] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));

        roomitems[25] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[26] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        
        Debug.Log("load rooom items done");
     }

    // creates all the buttons
    void createbuttons()
    {
        Button Roomitem0 = Unitybutton[1].GetComponent<Button>();
        Roomitem0.onClick.AddListener(OnClick1);

        Button Roomitem1 = Unitybutton[3].GetComponent<Button>();
        Roomitem1.onClick.AddListener(OnClick3);

        Button Roomitem2 = Unitybutton[4].GetComponent<Button>();
        Roomitem2.onClick.AddListener(OnClick4);
    }
}
