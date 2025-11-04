using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp11WorkingWithTests;
using NUnit.Framework;
namespace WorkingWithTestsTestProject2
{
    [TestFixture]
    public class UnitTest4
    {

        private Car? _car;

        [SetUp]
        public void Setup() {

            _car = new Car();

        }

        [TearDown]
        public void TearDown() {

            _car = null;
        }

        [Test]
        public void TestDefaultConstructor() {


            NUnit.Framework.Assert.That(_car.Doors, Is.EqualTo(2));
            NUnit.Framework.Assert.That(_car.Color, Is.EqualTo("black"));
        
        }
        
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        public void TestSetDoorsMethod(int doors) {


            NUnit.Framework.Assert.That(_car.Doors, Is.EqualTo(doors));
        
        }

    }
}
