using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FlipTest
    {
        int xScale = 22;
        bool facingRight = true;
        int faceLeft = -22;
        // A Test behaves as an ordinary method
        [Test]
        public void FlipTestSimplePasses()
        {

            //ACT
            facingRight = false;

            //ARRANGE

            if (facingRight == true)
            {
                xScale *= 1;
            }

            if (facingRight == false)
            {
                xScale *= -1;
            }

            //Assert
            Assert.That(xScale, Is.EqualTo(faceLeft));

        }
    }

}
