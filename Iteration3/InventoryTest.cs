using Iteration3;

namespace Iteration3;

[TestFixture()]
public class InventoryTest
{
    Inventory inv;
    Item shovel, sword, computer;
    string list;


    [SetUp()]
    public void Setup()
    {
        inv = new();
        shovel = new(new string[] { "shovel" }, "shovel", "");
        inv.Put(shovel);

        sword = new(new string[] { "sword" }, "sword", "bronze");
        inv.Put(sword);

        computer = new(new string[] { "pc" }, "computer", "small");
        inv.Put(computer);

        list = ("\t" + shovel.ShortDescription + "\n\t" +sword.ShortDescription + "\n\t" + computer.ShortDescription +"\n");
    }
    [Test()]
    public void Test_Find_Item()
    {

        Assert.That(inv.HasItem("shovel"), Is.True);
        Assert.That(inv.HasItem("sword"), Is.True);
        Assert.That(inv.HasItem("pc"), Is.True);
    }

    [Test()]
    public void Test_No_Item_Find()
    {
        Assert.That(inv.HasItem("food"), Is.False);

        Assert.That(inv.HasItem("boat"), Is.False);
    }

    [Test()]
    public void Test_Fetch_Item()
    {
        Assert.That(shovel, Is.EqualTo(inv.Fetch("shovel")));
        Assert.That(inv.HasItem("shovel"), Is.True);

        Assert.That(sword, Is.EqualTo(inv.Fetch("sword")));
        Assert.That(inv.HasItem("sword"), Is.True);

        Assert.That(computer, Is.EqualTo(inv.Fetch("pc")));
        Assert.That(inv.HasItem("pc"), Is.True);
    }

    [Test()]
    public void Test_Take_Item()
    {
        Assert.That(shovel, Is.EqualTo(inv.Take("shovel")));
        Assert.That(inv.HasItem("shovel"), Is.False);


        Assert.That(sword, Is.EqualTo(inv.Take("sword")));
        Assert.That(inv.HasItem("shovel"), Is.False);

        Assert.That(computer, Is.EqualTo(inv.Take("pc")));
        Assert.That(inv.HasItem("pc"), Is.False);
    }

    [Test()]
    public void Test_Item_List()
    {
        Assert.That(list, Is.EqualTo(inv.ItemList));
    }


}