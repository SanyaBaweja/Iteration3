using Iteration3;

namespace Iteration3;

[TestFixture()]
public class Identifiable_Object_Unit_Test
{
    Identifiable_object obj;



    [SetUp()]
    public void Constructor_Identifiable_Object_Unit_Test()
    {
        obj = new Identifiable_object(new string[] { "id1", "id2" });
    }
    [Test]
    public void Example_Identifiable_object()
    {

        Assert.Pass();
    }
    [Test]
    public void Test_Are_You()
    {

        Assert.IsTrue(obj.AreYou("id1"));
        Assert.IsTrue(obj.AreYou("id2"));

    }
    [Test]
    public void Test_Not_Are_You()
    {
        //Identifiable_object obj = new Identifiable_object(new string[] { "id1", "id2" });
        Assert.IsFalse(obj.AreYou("sanya"));
        Assert.IsFalse(obj.AreYou("baweja"));


    }
    [Test]
    public void Test_Case_Sensitive()
    {
        //Identifiable_object obj = new Identifiable_object(new string[] { "id1", "id2" });
        Assert.IsFalse(obj.AreYou("ID1"));
        Assert.IsFalse(obj.AreYou("ID2"));

    }
    [Test]
    public void Test_First_Id()
    {
        //Identifiable_object obj = new Identifiable_object(new string[] { "id1", "id2" });
        Assert.IsTrue(obj.FirstId == "id1");

    }
    [Test]
    public void Test_First_Id_with_no_Id()
    {
        Identifiable_object obj = new Identifiable_object(new string[] { });
        Assert.IsTrue(obj.FirstId == "");

    }
    [Test]
    public void Test_Add_Id()
    {
        //Identifiable_object obj = new Identifiable_object(new string[] {"id1", "id2"});
        obj.Addidentifier("id3");
        Assert.IsTrue(obj.AreYou("id1"));
        Assert.IsTrue(obj.AreYou("id2"));
        Assert.IsTrue(obj.AreYou("id3"));
    }

}
