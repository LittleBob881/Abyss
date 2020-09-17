using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    private static inventory playerInventory;
    private static inventory puzzleInventory;
    private static inventory usedInventory;
    public GameObject IExitButton;
    public GameObject IOpenButton;
    public GameObject[] Slot;



    public GameObject view;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start loaded");

        sprites = Resources.LoadAll<Sprite>("Itemsheet_6");
        //if
        createNewGame();
        //else 
        //add continue game load

        //view = GameObject.Find("InventoryView");

        Button openBtu = IOpenButton.GetComponent<Button>();
        openBtu.onClick.AddListener(OpenTaskOnClick);


        Button exitBtu = IExitButton.GetComponent<Button>();
        exitBtu.onClick.AddListener(ExitTaskOnClick);

        Button Slot1L = Slot[0].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);

        Button Slot2L = Slot[1].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot3L = Slot[2].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot4L = Slot[3].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot5L = Slot[4].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot6L = Slot[5].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot7L = Slot[6].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot8L = Slot[7].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot9L = Slot[8].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot10L = Slot[9].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot11L = Slot[10].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);
        Button Slot12L = Slot[11].GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);

        Debug.Log("You have clicked the button!");


        // hides the inventory at start of game. 
        view.gameObject.SetActive(false);
    }




    private void slot1OnClick()
    {
       // if () ;
        int slot= 1;
        
        updateactiveitem(slot);
        Button Slot1L = Slot[1].GetComponent<Button>();
        Sprite sprite = GetComponent<Sprite>();
        Slot1L.image.sprite = playerInventory.getActiveItemActiveimage();
    }


    private void updateactiveitem(int slot)
    {
        playerInventory.setActiveItem(slot);
        //player set active item

    }



    // Update is called once per frame
    void Update()
    {

        
    }

    void SlotActiveOnClick()
    {

    }

    void ExitTaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        view.gameObject.SetActive(false);

    }

    void OpenTaskOnClick()
    {
        Debug.Log("You have clicked the button!");
   
        for(int a = 0; a<11; a++)
        {
            Debug.Log(a);
            Button Slots = Slot[a].GetComponent<Button>();
            
            Slots.image.sprite = playerInventory.getInventorySlot(a).getImage();
        }
   


        view.gameObject.SetActive(true);

    }

    private void createNewGame()
    {
        
        puzzleInventory = new inventory();
        usedInventory = new inventory();
        inventoryItem item0 = new inventoryItem(0, sprites[0], sprites[0]);
        inventoryItem item1 = new inventoryItem(1, sprites[1], sprites[2]);
        inventoryItem item2 = new inventoryItem(2, sprites[3], sprites[4]);
        inventoryItem item3 = new inventoryItem(3, sprites[5], sprites[6]);
        inventoryItem item4 = new inventoryItem(4, sprites[7], sprites[8]);
        inventoryItem item5 = new inventoryItem(5, sprites[9], sprites[10]);
        inventoryItem item6 = new inventoryItem(6, sprites[11], sprites[12]);

        List<inventoryItem> inventorySlots= new List<inventoryItem>();
        
        for (int a = 0 ; a<12 ; ++a)
        {
            inventorySlots.Add(item0);
        }
        
        playerInventory = new inventory(inventorySlots);

        puzzleInventory.addInventoryItem(item1);
        puzzleInventory.addInventoryItem(item2);
        puzzleInventory.addInventoryItem(item3);
        puzzleInventory.addInventoryItem(item4);
        puzzleInventory.addInventoryItem(item5);
        puzzleInventory.addInventoryItem(item6);

      

        // set player aciveitem to notitemactive 

    }

    public class inventoryItem
    {

        private Sprite image;
        private Sprite activeImage;
        private int id;


        public inventoryItem(int id, Sprite image, Sprite active)
        {
            this.id = id;
            this.image = image;
            this.activeImage = active;


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
    }

    public class inventory
    {
        private List<inventoryItem> inventorySlots;
        private inventoryItem activeItem;
        private String empty;

        //for Initializing iventory class when loading a save file
        public inventory(List<inventoryItem> slots)
        {
            this.inventorySlots = slots;
            this.empty = "emptySlot";
        }

        //for Initializing iventory class when creating a new game.
        public inventory()
        {
            inventorySlots = new List<inventoryItem>();
            this.empty = "emptySlot";

        }

        //gets an iventory item at the slot location given to the method
        public inventoryItem getInventorySlot(int slot)
        {
            inventoryItem toreturn = this.inventorySlots[slot];
            return toreturn;
        }

        // adds and item to the inventorySlots list
        public void addInventoryItem(inventoryItem item)
        {
            this.inventorySlots.Add(item);
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

        //retuns the string held in empty
        public string getEmptyImage()
        {
            return this.empty;
        }

    }

}
