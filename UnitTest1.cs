using ConsoleApp11WorkingWithTests;

namespace WorkingWithTestsTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        private Car _car;

        [TestInitialize]
        public void Setup() {

            _car = new Car();
        }


        [TestMethod]
        public void TestDefaulConstructorToEnsureDefaultValuesAreSet()
        {

            Assert.AreEqual(2, _car.Doors);
            Assert.AreEqual("black", _car.Color);
        }
        
        [TestMethod]
        public void TestDoorsSetterWithValidValue() {

            _car.Doors = 4;
            Assert.AreEqual(4, _car.Doors);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDoorsSetterWithInvalidValue() {

            _car.Doors = 3;
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(5)]

        public void TestDoorsSettingWithMulipleValidValues(int door) {

            _car.Doors = door;
            Assert.AreEqual(door, _car.Doors);
        }

    }
}
