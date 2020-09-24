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

    void Start()
    {
        Debug.Log("Start fruriture script");
        loadRoomItems();
       
        Button Roomitem0 = Unitybutton[1].GetComponent<Button>();
        Roomitem0.onClick.AddListener(OnClick1);

        Button Roomitem1 = Unitybutton[3].GetComponent<Button>();
        Roomitem1.onClick.AddListener(OnClick3);

        Button Roomitem2 = Unitybutton[4].GetComponent<Button>();
        Roomitem2.onClick.AddListener(OnClick4);
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
        if (roomitems[num].GetItem() != 0)
        {

            _ = invenScript.GetPlayerInventory().PickupItem(list.GetPuzzleInventory().getInventorySlot(roomitems[num].GetItem()));

        }
    }

     void loadRoomItems()
    {
        roomitems = new AbyssLibrary.RoomItem[12];
        string[] Strings0 = { "Chair for a child", "meh" };
        string[] Strings1 = { "Its a table", "There is a recipe on the table, added to notebook." };
        string[] Strings2 = { "Its a very large pot", "Added tomato to pot" };
        string[] Strings3 = { "Its an oven", "Its hot." };
        string[] Strings4 = { "Its chilly in here", "There is a tomato here, added to inventory" };
        roomitems[0] = new AbyssLibrary.RoomItem("Kitchen", "Highchair", Strings0, 0, 0);
        roomitems[1] = new AbyssLibrary.RoomItem("Kitchen", "Table", Strings1, 0, 2);
        roomitems[2] = (new AbyssLibrary.RoomItem("Kitchen", "oven", Strings2, 0, 0));
        roomitems[3] = (new AbyssLibrary.RoomItem("Kitchen", "Pot", Strings3, 0, 0));
        roomitems[4] = (new AbyssLibrary.RoomItem("Kitchen", "Fridge", Strings4, 3, 0));


        Debug.Log("load rooom items done");
    }
}
