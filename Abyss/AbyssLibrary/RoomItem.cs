using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssLibrary
{
    class RoomItem
    {
        private String room;
        private String output;
        private string[] dialog;
        private int item;
        private int dialogNumber;


        public RoomItem(String room, string[] textlines, int item)
        {
            this.room = room;
            this.output = "  ";
            this.dialog = textlines;
            this.item = item;
            this.dialogNumber = 0;

        }

        //returns output as a string
        public String GetOutput()
        {
            return this.output;
        }

        // sets output from the diaglog list. int chooses which dialog is used.

        public void SetOutput(int num)
        {
            this.output = dialog[num];
        }


        // returns item (not sure how this will work with the item getting.)
        public int GetItem()
        {
            return item;

        }

        // sets the Dialog number. 
        public void SetDialogNum(int num)
        {
            this.dialogNumber = num;
        }
    }
}
