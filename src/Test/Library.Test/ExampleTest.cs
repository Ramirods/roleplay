using NUnit.Framework;
using Program;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }

        [Test]
        public void RecibirDanio1()
        {
            int expected = 90;
            Enano legolas = new Enano ("Tony1", 100 , 10, 10);
            Enano enano1  = new Enano("Tony", 100 , 20, 10);
            legolas.RecibirDanio(enano1.Danio);
            Assert.AreEqual(legolas.Vida, expected); 
       
        }
 
    }
}