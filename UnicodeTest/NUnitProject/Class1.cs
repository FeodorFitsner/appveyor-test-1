using NUnit.Framework;

namespace NUnitProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.Fail("Русские буквы из NUnit.");
        }
    }
}
