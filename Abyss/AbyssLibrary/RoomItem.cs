using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssLibrary
{
    public class RoomItem
    {
        private String room;
        private String name;
        private String output;
        private string[] dialog;
        private int item;
        private int page;
        private int dialogNumber;


        public RoomItem(String room, String name, string[] textlines, int item, int page)
        {
            this.room = room;
            this.name = name;
            this.output = "  ";
            this.dialog = textlines;
            this.item = item;
            this.page = page;
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

        // returns item (not sure how this will work with the page getting.)
        public int GetPage()
        {
            return page;

        }

        // sets the Dialog number. 
        public void SetDialogNum(int num)
        {
            this.dialogNumber = num;
        }
    }
}
