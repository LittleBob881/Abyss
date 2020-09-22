using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssLibrary
{
    class TestingStuff
    {
        // in this class you can test your stuff. This is basicly garbage bin so do what you want with it. 
        // I made it so i could make stuff here and get the debuger to tell me what I did wrong as the unity
        // scripts dont tell us.


        // Assert.That(playerinventory.getEmpty, is.EqualTo(inventoryIsStatic));

        inventoryItem item1 = new inventoryItem(1, "bone", "boneA");
        inventoryItem item2 = new inventoryItem(2, "pen", "penA");
        inventoryItem item3 = new inventoryItem(3, "tomato", "tomatoA");
        inventoryItem item4 = new inventoryItem(4, "onion", "onionA");
        inventoryItem item5 = new inventoryItem(5, "crayons", "crayonsA");
        inventoryItem item6 = new inventoryItem(6, "key", "keyA");

    }
}
