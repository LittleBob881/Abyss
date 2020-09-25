using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class WalkTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void WalkTestSimplePasses()
        {
            // Use the Assert class to test conditions
            var walk = new Walk();
            var left = -1056;
            var right = 1056;
            Sprite character = Resources.Load("main_sheet1");

            int i = 0;
            while (i < Input.touchCount)
            {
                if (Input.GetTouch(i).position.x > ScreenWidth / 2)
                {
                    //Walking Right
                    walkCharacter(right);
                }
                if (Input.GetTouch(i).position.x < ScreenWidth / 2)
                {
                    //Walking left
                    walkCharacter(left);
                }
                ++i;
            }

            //Act
            var walkingSide = walk.walkCharacter();


            //Assert
            Assert.That(walk, ISet.EqualTo(left));
        }
    }

}
