using System;
using System.Xml.Linq;
using Iteration3;
namespace Iteration3
{
    [TestFixture()]
    public class BagTest
    {

        
        Bag bag1, bag2;
        Item shovel, sword;
       

        [SetUp()]
        public void Constructor_BagTest()
        {

            //bag1 = new(new string[] { "bag" }, "leather bag", "small brown");
            bag1 = new Bag(new string[] { "bag" }, "leather bag", "small brown");
            bag2 = new Bag(new string[] { "bag2" }, "Jute bag", "pretty big");
            shovel = new Item(new string[] { "shovel" }, "shovel", "");
            sword = new Item(new string[] { "sword" }, "sword", "bronze");

            bag1.Inv.Put(shovel);
            bag2.Inv.Put(sword);
            bag1.Inv.Put(bag2);
           
            

        }
        [Test()]
        public void Test_Bag_Locates_Items()
        {

            Assert.AreEqual(shovel, bag1.Locate("shovel"));
            Assert.IsTrue(bag1.Inv.HasItem("shovel"));

            Assert.AreEqual(sword, bag2.Locate("sword"));
            Assert.IsTrue(bag2.Inv.HasItem("sword"));

        }
        [Test()]
        public void Test_Bag_Locates_Itself()
        {
            Assert.AreEqual(bag1, bag1.Locate("bag"));
            Assert.AreEqual(bag2, bag2.Locate("bag2"));

        }
        [Test()]
        public void Test_Bag_Locates_Nothing()
        {
            Assert.AreNotEqual(bag1, bag1.Locate("nothing"));

            Assert.AreNotEqual(bag2, bag2.Locate("nothing"));
        }
        [Test()]
        public void Test_Bag_Full_Description()
        {
            Assert.AreEqual(bag1.FullDescription, "In this leather bag you can see:\n\ta shovel (shovel)\n\ta Jute bag (bag2)\n");

            Assert.AreEqual(bag2.FullDescription, "In this Jute bag you can see:\n\ta sword (sword)\n");
        }
        [Test()]
        public void Test_Bag_In_Bag()
        {
            Assert.AreEqual(bag2, bag1.Locate("bag2"));
            Assert.AreEqual(shovel, bag1.Locate("shovel"));

            Assert.AreNotEqual(sword, bag1.Locate("sword"));

        }

    }
}

