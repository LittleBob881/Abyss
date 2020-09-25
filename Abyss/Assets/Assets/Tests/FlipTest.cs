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
        // A Test behaves as an ordinary method
        [Test]
        public void FlipTestSimplePasses()
        {
            // Use the Assert class to test conditions
            var flip = new Flip();
            var hori = 22;
            var faceLeft = -22;

            
            //Action
            flip.flipCharacter(hori);


            //Assert
            // Assert.That(flip.getScale(), Is.EqualTo(faceLeft));
            flip.getScale();

        }
    }

}
