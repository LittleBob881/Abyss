using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    private static inventory playerInventory;
    private PuzzleScript.PuzzleRefeanceItems alist;
    public GameObject IExitButton;
    public GameObject IOpenButton;
    public GameObject[] Slot;



    public GameObject view;
    static public Sprite[] sprites;
    static public inventoryItem Empty;


    void Start()
    {
        sprites = Resources.LoadAll<Sprite>("Itemsheet_6");
        alist = new PuzzleScript.PuzzleRefeanceItems();
        createNewGame();

        Button openBtu = IOpenButton.GetComponent<Button>();
        openBtu.onClick.AddListener(OpenTaskOnClick);


        Button exitBtu = IExitButton.GetComponent<Button>();
        exitBtu.onClick.AddListener(ExitTaskOnClick);

        Button Slot0L = Slot[0].GetComponent<Button>();
        Slot0L.onClick.AddListener(slot0OnClick);

        Button Slot1L = Slot[1].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot2L = Slot[2].GetComponent<Button>();
        Slot2L.onClick.AddListener(slot2OnClick);
        Button Slot3L = Slot[3].GetComponent<Button>();
        Slot3L.onClick.AddListener(slot3OnClick);
        Button Slot4L = Slot[4].GetComponent<Button>();
        Slot4L.onClick.AddListener(slot4OnClick);
        Button Slot5L = Slot[5].GetComponent<Button>();
        Slot5L.onClick.AddListener(slot5OnClick);
        Button Slot6L = Slot[6].GetComponent<Button>();
        Slot6L.onClick.AddListener(slot6OnClick);
        Button Slot7L = Slot[7].GetComponent<Button>();
        Slot7L.onClick.AddListener(slot7OnClick);
        Button Slot8L = Slot[8].GetComponent<Button>();
        Slot8L.onClick.AddListener(slot8OnClick);
        Button Slot9L = Slot[9].GetComponent<Button>();
        Slot9L.onClick.AddListener(slot9OnClick);
        Button Slot10L = Slot[10].GetComponent<Button>();
        Slot10L.onClick.AddListener(slot10OnClick);
        Button Slot11L = Slot[11].GetComponent<Button>();
        Slot11L.onClick.AddListener(slot11OnClick);

        // hides the inventory at start of game. 
        view.gameObject.SetActive(false);
    }


 

    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot0OnClick()
    {
        int num = 0;
        SlotButtonAction(num);
    }

    // num == what slot is clicked.
    // calls SlotButtonAction.
    private void slot1OnClick()
    {
        int num = 1;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot2OnClick()
    {
        int num = 2;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot3OnClick()
    {
        int num = 3;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot4OnClick()
    {
        int num = 4;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot5OnClick()
    {
        int num = 5;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot6OnClick()
    {
        int num = 6;
        SlotButtonAction(num);
    }
    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot7OnClick()
    {
        int num = 7;
        SlotButtonAction(num);
    }

    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot8OnClick()
    {
        int num = 8;
        SlotButtonAction(num);
    }

    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot9OnClick()
    {
        int num = 9;
        SlotButtonAction(num);
    }

    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot10OnClick()
    {
        int num = 10;
        SlotButtonAction(num);
    }

    // num == what slot is clicked.
    // calls SlotButtonAction.

    private void slot11OnClick()
    {
        int num = 11;
        SlotButtonAction(num);
    }


    //checks if item in slot is not empty.
    //checks if item is not active.
    //updates the activeitem to be the item in this slot.
    //changes the sprite in the slot to be the activeimage of the item. 
    //if item was already active. 
    // sets the item in the slot to no active. 
    // sets player inventory's active item to empty item.
    private void SlotButtonAction(int num)
    {
        if (playerInventory.getInventorySlot(num).getID() != 0)
        {
            if (playerInventory.getInventorySlot(num).getActive() == false)
            {
                updateactiveitem(num);
                Button Slots = Slot[num].GetComponent<Button>();
                Slots.image.sprite = playerInventory.getActiveItemActiveimage();
            }
            else
            {
                playerInventory.getInventorySlot(num).setActive(false);
                playerInventory.setActiveItemToEmpty();
                Button Slots = Slot[num].GetComponent<Button>();
                Slots.image.sprite = playerInventory.getInventorySlot(num).getImage();
            }
        }
    }

    // checks if there is is all ready an active item
    // finds what slot the old active item is in and gets that slot and activate the button as oldactive 
    // change oldactive image to normal image. 
    // sets item of old active not active.
    // sets the new active item to the item thats in the slot that was pressed
    // sets new active item to active 

    private void updateactiveitem(int slot)
    {
        if (playerInventory.getActiveItemID() != 0)
        {
            Button oldactive = Slot[playerInventory.CheckforActiveItem()].GetComponent<Button>();
            oldactive.image.sprite = playerInventory.getInventorySlot(playerInventory.CheckforActiveItem()).getImage();
            playerInventory.getInventorySlot(playerInventory.CheckforActiveItem()).setActive(false);
        }
        playerInventory.setActiveItem(slot);
        playerInventory.getInventorySlot(slot).setActive(true);

    }


    public inventory GetPlayerInventory()
    {
        return playerInventory;
    }

    // closes the inventory
    void ExitTaskOnClick()
    {
        view.gameObject.SetActive(false);

    }

    // open the invetory and updates the items in inventory.
    void OpenTaskOnClick()
    {
        Debug.Log("You have clicked the button!");
   
        for(int a = 0; a<11; a++)
        {
            Debug.Log(a);
            Button Slots = Slot[a].GetComponent<Button>();
            Slots.image.sprite = playerInventory.getInventorySlot(a).getImage();
        }
        
        if (playerInventory.getActiveItemID() != 0)
        {
           
            for(int k = 0; k < 11; k++)
            {
                if (playerInventory.getActiveItemID() == playerInventory.getInventorySlot(k).getID())
                {
                    Button Slots = Slot[k].GetComponent<Button>();
                    Slots.image.sprite = playerInventory.getActiveItemActiveimage();
                }
            }

        } 
            view.gameObject.SetActive(true);

    }

    //sets the inventory to empty
    private void createNewGame()
    {
        Empty = new inventoryItem("empty", 0, sprites[0], sprites[0]);
    
        List<inventoryItem> inventorySlots= new List<inventoryItem>();
        
        for (int a = 0 ; a<12 ; ++a)
        {
            inventorySlots.Add(Empty);
        }
        
        playerInventory = new inventory(inventorySlots);
    }


    // removes item from inventory by itemId 
    // checks if the to remove itemId is the same as 
    public void RemoveItemFromInventory(int ItemID)
    {

        for (int k = 0; k < 11; k++)
        {
            if (ItemID == playerInventory.getInventorySlot(k).getID())
            {
                playerInventory.RemoveInventoryItem(k);
            }
        }

       
    }



    public class inventoryItem
    {
        private String name;
        private Sprite image;
        private Sprite activeImage;
        private int id;
        private Boolean active; 


        public inventoryItem(String name,int id, Sprite image, Sprite active)
        {
            this.name = name;
            this.id = id;
            this.image = image;
            this.activeImage = active;


        }

        public String getName()
        {
            return this.name;
        }

        public int getID()
        {
            return this.id;
        }

        public Sprite getImage()
        {
            return this.image;
        }

        public Sprite getActiveImage()
        {
            return this.activeImage;
        }

        public Boolean getActive()
        {
            return this.active;
        }

        public void setActive(Boolean bol)
        {
            this.active = bol;
        }
    }

    public class inventory
    {
        private List<inventoryItem> inventorySlots;
        private inventoryItem activeItem;
        private inventoryItem empty;

        //for Initializing iventory class when loading a save file
        public inventory(List<inventoryItem> slots)
        {
            this.inventorySlots = slots;
            this.empty = Empty;
            this.activeItem = this.empty;
        }

        //for Initializing iventory class when creating a new game.
        public inventory()
        {
            inventorySlots = new List<inventoryItem>();
            this.empty = Empty;
            this.activeItem = this.empty;
        }

     

        //gets an iventory item at the slot location given to the method
        public inventoryItem getInventorySlot(int slot)
        {
            
            return inventorySlots[slot];
        }


        // creates a new list without the item that needs to be removed. 
        //The items that were behind the removed item is moved up a slot.
        // the last slots is filled with an empty item.
        // sets active item to empty
        public void RemoveInventoryItem(int slot)
        {
            List<inventoryItem> NewSLots = new List<inventoryItem>();
            for (int k=0; k<=10; k++)
            {
                if(k != slot)
                {
                    NewSLots.Add( this.inventorySlots[k]);
                }
            }

            NewSLots.Add(empty);
            setActiveItemToEmpty();
            this.inventorySlots = NewSLots;
        }

        // adds and item to the inventorySlots list
        public void addInventoryItem(inventoryItem item)
        {
            this.inventorySlots.Add(item);
        }


        // finds the first empty slot 
        // returns 55 if inventory full
        public int FristEmptySlot()
        {
            int toreturn = 55;
            for (int k = 0; k <= 11; k++)
            {
               if (inventorySlots[k].getID() == 0)
                {
                    return k;
                }
            }
            return toreturn;
        }

        public void SetInventoryItem(inventoryItem item,int num)
        {
            this.inventorySlots[num] = item;
        }

        public void setActiveItemToEmpty()
        {
            this.activeItem = this.empty;
        }

        //sets active item. When a player taps on a slot, an int of which slot is sent
        //                  to here and an iventoryItem is taken from invetorySlots list
        //					dependint on what int is sent and saved into activeItem. 
        public void setActiveItem(int slot)
        {
            this.activeItem = this.inventorySlots[slot];
        }

        //returns the ativeImage of the activeItem 
        public Sprite getActiveItemActiveimage()
        {
            return this.activeItem.getActiveImage();
        }

        public int getActiveItemID()
        {
            return this.activeItem.getID();
        }
        public String getActiveItemName()
        {
            Debug.Log(activeItem.getName());
            Debug.Log(this.activeItem.getID());
            return this.activeItem.getName();
        }

        //retuns the string held in empty
        public inventoryItem getEmptyImage()
        {
            return this.empty;
        }


        // checks if there is this item in the inventory, so there is not doubles.
        // returns true if there is already that item in the inventory. returns false if not. 
        public Boolean Checkforitem(int num)
        {
            Boolean toreturn = false;
            for (int k = 0; k < inventorySlots.Count; k++)
            {
                if (inventorySlots[k].getID()== num)
                {
                    toreturn = true;
                }
            }
            return toreturn;
        }

        // checks the inventory slots for the slot that has the item with the item id of the activeitem
        public int CheckforActiveItem()
        {
            int toreturn = 55;
            for (int k = 0; k < inventorySlots.Count; k++)
            {
                if (inventorySlots[k].getID() == activeItem.getID())
                {
                    toreturn = k;
                }
            }
            return toreturn;
        }


        // false = item was not picked up
        // 1 checks if the item picking is already in inventory if it is then check is true. if it is not then false. 
        // 2 finds the first empty slot
        // if newslot == 55 invenvtory is full 
        //sets first empty slot (from step 2) in playerInventory with the item from puzzleInventory 
        //  with the item id that was given into this meathord. 
        // returns true if the item was added to the playerInventory. 

        public Boolean PickupItem(inventoryItem aItem)
        {
            int newSlot;
            Boolean toreturn = false;
            Boolean check = Checkforitem(aItem.getID());
            if (check == false)
            {
                newSlot = FristEmptySlot();
                if (newSlot == 55)
                {
                    return false;
                }
                else
                {
                    SetInventoryItem(aItem, newSlot);
                    
                    toreturn = true;
                }

            }

            return toreturn;
        }


    }

    static public inventoryItem getItemForTest()
    {
        return new inventoryItem("empty", 3, sprites[5], sprites[6]);
    }



}
