using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSub101;

namespace NSub101Tests
{
    [TestClass]
    public class Person_Tests
    {
        [TestMethod]
        public void Simple_Test()
        {
            //Create a substitute instance for the IPerson type
            var person = Substitute.For<IPerson>();
            //Tell our substitute to return a value for the call
            person.GetFullName("Paul", "Brodzinski").Returns("Paul Brodzinski");
            //Typically, you would have a builder class that creates the Substitution implementations for you

            //Perform your unit test Assert against your now substituted method
            Assert.AreEqual("Paul Brodzinski", person.GetFullName("Paul", "Brodzinski"));
        }
    }
}
