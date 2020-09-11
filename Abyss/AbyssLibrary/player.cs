using System;



	public class player
	{
		inventoryItem activeItem;
		inventoryItem notActiveItem;

	public player()
		{
		notActiveItem = new inventoryItem(0, "false", "false");
		activeItem = notActiveItem;
		}


		//Sets the active item with an item.
		public void setActiveItem(inventoryItem item)
		{
			this.activeItem = item;

		}

		//when a player clicks on an active item do unactivate an item or uses an item susscefull this 
		//methord is used to set the player to have no item in hand. Item 0 should not work on any puzzles. 
		public void unactivateActiveItem()
		{
		this.activeItem = notActiveItem;
		}
	}
