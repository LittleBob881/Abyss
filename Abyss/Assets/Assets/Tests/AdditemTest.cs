using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AdditemTest
    {
       
        // A Test behaves as an ordinary method
        [Test]
        public void AdditemTestSimplePasses()
        {
            //tests that the task of geting a item from an room item adds an item to a inventory. 
             
            //ARANGE
            //Creates the room item
            string[] Strings2 = { "Its chilly in here", "There is a tomato here, added to inventory" };
            var fridge = (new FurnitureScript.RoomItem("Kitchen", "Fridge", Strings2, 3, 0));
            //creates the item
            PuzzleScript.PuzzleRefeanceItems puzzle = new PuzzleScript.PuzzleRefeanceItems();
            inventoryScript.inventoryItem TestTomato = puzzle.GetPuzzleInventory().getInventorySlot(3);     // creates the invetory 
            List<inventoryScript.inventoryItem> inventorySlots = new List<inventoryScript.inventoryItem>();
            for (int a = 0; a < 12; ++a)
            {
                inventorySlots.Add(puzzle.GetPuzzleInventory().getInventorySlot(0));
            }
            var inventory = new inventoryScript.inventory(inventorySlots);





            //ACT

            inventory.PickupItem(puzzle.GetPuzzleInventory().getInventorySlot(fridge.GetItem()));

            //ASSERT


            Assert.AreEqual(TestTomato, inventory.getInventorySlot(0));

        }


    }
}
