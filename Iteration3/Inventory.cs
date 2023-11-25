using System;
namespace Iteration3
{
	public class Inventory
	{
		private List<Item> _items = new List<Item>();
		public Inventory()
		{
		}

		public bool HasItem(string id)
		{
			foreach(Item i in _items)
			{
				if (i.AreYou(id))
				{
					return true;
				}
				
			}
            return false;
        }
		public void Put(Item itm)
		{
			_items.Add(itm);
		}
		public Item Take(string id)
		{
            Item i = Fetch(id);

            if (_items != null)
            {
                _items.Remove(i);
                return i;
            }
            return null;
        }
		public Item Fetch(string id)
		{
			foreach(Item i in _items)
			{
				if (i.AreYou(id))
				{
					return i;
				}
			}
			return null;

		}
		public string ItemList
		{
			get
			{
                string l = "";

                foreach (Item i in _items)
				{
					l += "\t"+ i.ShortDescription + "\n";
				}
				return l;

            }
		}
	}
}

