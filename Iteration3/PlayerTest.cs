using System;
using System.Xml.Linq;

namespace Iteration3
{
	public class PlayerTest
	{
		
		Item shovel, sword, computer;
		Player pl;
		string stdesc;


		[SetUp()]
		public void Constructor_PlayerTest()
		{
			
            pl = new("Fred", "the mighty programmer");
            shovel = new(new string[] { "shovel" }, "shovel", "");
            sword = new(new string[] { "sword" }, "sword", "bronze");
            computer = new(new string[] { "pc" }, "computer", "small");
			

            pl.Inv.Put(shovel);
            pl.Inv.Put(sword);
			pl.Inv.Put(computer);
            stdesc = "You are Fred the mighty programmer.\n" + "You are carrying\n" + pl.Inv.ItemList;

        }
		[Test()]
		public void Test_Player_is_Identifiable()
		{
			Assert.IsTrue(pl.AreYou("me"));
		}
		[Test()]
		public void Test_Player_Locates_Items()
		{
			Assert.That(pl.Locate("shovel"), Is.EqualTo(shovel));
            Assert.That(pl.Inv.HasItem("shovel"), Is.True);


            Assert.That(pl.Locate("sword"), Is.EqualTo(sword));
            Assert.That(pl.Inv.HasItem("sword"), Is.True);


            Assert.That(pl.Locate("pc"), Is.EqualTo(computer));
            Assert.That(pl.Inv.HasItem("pc"), Is.True);

        }
		[Test()]
		public void Test_Player_Locates_Itself()
		{
            Assert.AreEqual(pl, pl.Locate("me"));
            Assert.AreEqual(pl, pl.Locate("inventory"));

        }
		[Test()]
		public void Test_Player_Locates_Nothing()
		{
			Assert.AreEqual(pl.Locate("food"), pl.Locate(null));

            Assert.AreEqual(pl.Locate("boat"), pl.Locate(null));
        }
		[Test()]
		public void Test_Player_full_Description()
		{
			Assert.AreEqual(pl.FullDescription, stdesc);
		}
    }
}

