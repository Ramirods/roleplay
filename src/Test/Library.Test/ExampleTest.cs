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
            Enano enanoVirgo1  = new Enano("Tony", 100 , 10, 10);
            legolas.RecibirDanio(enanoVirgo1.Danio);
            Assert.AreEqual(legolas.Vida, expected); 
       
        }
 
    }
}