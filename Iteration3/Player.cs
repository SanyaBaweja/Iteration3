using System;
namespace Iteration3
{
	public class Player: Game_Object
	{
		Inventory _inventory = new Inventory();

		public Player(string name, string desc):base(new string[] {"me", "inventory"}, name, desc)
		{
			//Inventory _inventory = new() Inventory;
		}

		public Game_Object Locate(string id)
		{
			if(AreYou(id) == true)
			{
				return this;
			}
			return _inventory.Fetch(id);
		}
		public Inventory Inv
		{
			get
			{
				return _inventory;
			}
		}
        public override string FullDescription //! Can only override virtual properties
        {
            get
			{
				return ("You are " + Name + " " + base.FullDescription + "." + "\nYou are carrying\n" + Inv.ItemList);
			}
        }
    }
}

