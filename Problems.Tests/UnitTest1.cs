using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestOne(){
            var ans1 = "5,1:hello";
            var rslt1 = Prefix("hello");  

            var ans2 = "0,0:";
            var rslt2 = Prefix("");

            var ans3 = "27,5:what ... did you say?? ";
            var rslt3 = Prefix("what ... did you say?? ");

            Assert.AreEqual(ans1, rslt1);

        }
    }
}