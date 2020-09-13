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
    public GameObject Slot1;
    
    public GameObject view;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You have clicked the button!");
        //if
        createNewGame();
        //else 
        //add continue game load

        //view = GameObject.Find("InventoryView");

        sprites = Resources.LoadAll<Sprite>("Itemsheet_6");
        Button btu = IExitButton.GetComponent<Button>();
        btu.onClick.AddListener(ExitTaskOnClick);

        Button Slot1L = Slot1.GetComponent<Button>();
        Slot1L.onClick.AddListener(slot1OnClick);



        Debug.Log("You have clicked the button!");
    }

    private void slot1OnClick()
    {
        int slot= 1;
        
        updateactiveitem(slot);
        Button Slot1L = Slot1.GetComponent<Button>();
        Sprite sprite = GetComponent<Sprite>();
        //Slot1L.image.sprite = playerInventory.getActiveItemActiveimage();
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

    private void createNewGame()
    {
        playerInventory = new inventory();
        puzzleInventory = new inventory();
        usedInventory = new inventory();

        inventoryItem item1 = new inventoryItem(1, "bone", "boneA");
        inventoryItem item2 = new inventoryItem(2, "pen", "penA");
        inventoryItem item3 = new inventoryItem(3, "tomato", "tomatoA");
        inventoryItem item4 = new inventoryItem(4, "onion", "onionA");
        inventoryItem item5 = new inventoryItem(5, "crayons", "crayonsA");
        inventoryItem item6 = new inventoryItem(6, "key", "keyA");

        

        puzzleInventory.addInventoryItem(item1);
        puzzleInventory.addInventoryItem(item2);
        puzzleInventory.addInventoryItem(item3);
        puzzleInventory.addInventoryItem(item4);
        puzzleInventory.addInventoryItem(item5);
        puzzleInventory.addInventoryItem(item6);

      

        // set player aciveitem to notitemactive 

    }


}
