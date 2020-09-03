using System;

public class inventoryItem
{

	private string image;
	private string activeImage;
	private int id;

	public inventoryItem(int id, string image, string active)
	{
		this.id = id;
		this.image = image;
		this.activeImage = active;


	}

	public int getID()
    {
		return this.id;
    }

	public string getImage()
    {
		return this.image;
    }

	public string getActiveImage()
    {
		return this.activeImage;
    }
}
