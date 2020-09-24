using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ForwardButtonTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ForwardButtonTestScriptSimplePasses()
        {
            //ARRANGE
            var noteBook = new NoteBook();

            //Making the Notebook
            noteBook = new NoteBook();
            Sprite[] sprites = Resources.LoadAll<Sprite>("Pagespage");
            for (int i = 0; i < sprites.Length; i++)
            {
                noteBookPage page = new noteBookPage(sprites[i], i);
                noteBook.addNoteBookPage(page);

                if (i == 1)
                {
                    noteBook.setActivePage(page);
                }
            }
            noteBook.unlockPage(0);
            noteBook.unlockPage(1);
            noteBook.unlockPage(2);

            var expectedPage = noteBook.getPage(2);

            //ACT
            noteBook.turnPageForward();
            var currentPage = noteBook.getActivePage();

            //ASSERT
            Assert.That(expectedPage, Is.EqualTo(noteBook.getActivePage()));
        }
    }
}
