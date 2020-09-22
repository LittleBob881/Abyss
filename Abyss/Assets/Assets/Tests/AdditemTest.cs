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
            var inventory = new PickupItem();
            //ACT

            //ASSERT


            // Assert.AreEqual(inventoryIsStatic, inventoryScript.playerInventory.getEmptyImage());

        }


    }
}
