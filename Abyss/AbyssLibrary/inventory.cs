using System;
using System.Collections;




	public class inventory
	{
		private ArrayList inventorySlots;
		private inventoryItem activeItem;
		private String empty;
		public inventory(ArrayList slots)
		{
			this.inventorySlots = slots;
			this.empty = "emptySlot";
		}

		public inventory()
		{
			this.empty = "emptySlot";




		}


	}

