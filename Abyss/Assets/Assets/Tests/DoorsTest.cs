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
            Debug.Log("Loading first scene.");
            EditorSceneManager.OpenScene("Assets/Scenes/Hallway.unity");
            Debug.Log("Loading this dude.");
            string KitchenDoor = "KitchenDoor";
            // Use the Assert class to test conditions
            Assert.IsTrue(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Hallway"));
            Debug.Log("Dude bro is loaded and ready to go baybe");
           var door = GameObject.Find(KitchenDoor);
            Assert.IsNotNull(door, "Missing Button" + KitchenDoor);
            Debug.Log("Button is here.");

            //Set as selected
            EventSystem.current.SetSelectedGameObject(door);
            door.GetComponent<Button>().onClick.Invoke();
            Debug.Log("Button click");
            Assert.IsTrue(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Kitchen"));
            Debug.Log("U changed!!");
        }

    }
}
