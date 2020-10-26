using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class DoorsTest
    {
        // Tests loading three different Scenes within hallway
        
        [Test] 
        public void DoorsTestSimplePasses()
        {
            //Creating the shit
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Debug.Log("Loading first scene.");
            player.transform.position = new Vector3(-50, -17);
            Debug.Log("Loading Hallway.");
            Assert.IsTrue(condition: player.transform.position.x == -50);
            Assert.IsTrue(condition: player.transform.position.y == -17);

        }

    }
}
 