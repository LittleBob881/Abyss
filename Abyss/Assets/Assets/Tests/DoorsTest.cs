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
            Debug.Log("Loading Hallway.");


            // Use the Assert class to test conditions
            Assert.IsTrue(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Hallway"));
            Debug.Log("Hallway is Loaded");

            EditorSceneManager.OpenScene("Assets/Scenes/Lounge.unity");
            Debug.Log("Loading Lounge.");
            Assert.IsTrue(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Lounge"));
            Debug.Log("Lounge is Loaded. Changed from hallway.");

            EditorSceneManager.OpenScene("Assets/Scenes/Kitchen.unity");
            Debug.Log("Loading Kitchen.");
            Assert.IsTrue(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Kitchen"));
            Debug.Log("Kitchen is Loaded. Changed from Kitchen.");
        }

    }
}
