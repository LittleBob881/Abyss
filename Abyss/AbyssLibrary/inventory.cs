using System;
using System.Collections;
using System.Collections.Generic;

public class inventory
{
	private List<inventoryItem> inventorySlots;
	private inventoryItem activeItem;
	private String empty;

	//for Initializing iventory class when loading a save file
	public inventory(List<inventoryItem> slots)
	{
			this.inventorySlots = slots;
			this.empty = "emptySlot";
	}

	//for Initializing iventory class when creating a new game.
	public inventory()
	{
		this.empty = "emptySlot";
	}

	//gets an iventory item at the slot location given to the method
	public inventoryItem getInventorySlot(int slot)
	{
		inventoryItem toreturn = this.inventorySlots[slot];
		return toreturn;
	}

	// adds and item to the inventorySlots list
	public void addInventoryItem(inventoryItem item)
	{
		this.inventorySlots.Add(item);
	}

	//sets active item. When a player taps on a slot, an int of which slot is sent
	//                  to here and an iventoryItem is taken from invetorySlots list
	//					dependint on what int is sent and saved into activeItem. 
	public void setActiveItem(int slot)
	{
		this.activeItem = this.inventorySlots[slot];
	}

	//returns the ativeImage of the activeItem 
	public string getActiveItemActiveimage()
    {
		return this.activeItem.getActiveImage();
    }

	//retuns the string held in empty
	public string getEmptyImage()
    {
		return this.empty;
    }

}

