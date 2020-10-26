using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class MainMenuTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MainMenuTestSimplePasses()
        {
            //ARRANGE
            var main = EditorSceneManager.OpenScene("Assets/Scenes/titlemenu/MainMenu");
            var WorldScene = EditorSceneManager.OpenScene("Assets/Scenes/World");


            //Adding next scene 
            EditorSceneManager.LoadScene(main.buildIndex + 1);


            //ASSERT
            Assert.That(main, Is.EqualTo(WorldScene));

        }
    }
}
