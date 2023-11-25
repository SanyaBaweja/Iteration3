using Iteration3;

namespace Iteration3;


    [TestFixture()]
    public class ItemUnitTest1
    {
        Item itemTest;
        String testShortDescription;

        [SetUp()]
        public void Setup()
        {
            itemTest = new(new string[] { "pc" }, "computer", "small");
            testShortDescription = "a computer (pc)";
        }

        [Test()]
        public void Test_Item_Is_Identifiable()
        {
            Assert.That(itemTest.AreYou("pc"), Is.True);
        }

        [Test()]
        public void Test_Short_Description()
        {
            Assert.That(itemTest.ShortDescription, Is.EqualTo(testShortDescription));
        }

        [Test()]
        public void Test_Full_Description()
        {
            Assert.That(itemTest.FullDescription, Is.EqualTo("small"));
        }
    }

