using ConsoleApp11WorkingWithTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace WorkingWithTestsTestProject2
{
    public class UnitTest3
    {

        [Fact]
        public void TestCarDefaultConstructor() {

            Car car = new Car();

            Xunit.Assert.Equal(2, car.Doors);
            Xunit.Assert.Equal("black",car.Color);
        
        }

        [Theory] //pass values to a testing method
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        public void TestSetCarDoorsMethod(int doors)
        {

            Car car = new Car();
            car.Doors = doors;
            Xunit.Assert.Equal(doors, car.Doors);

        }

        [Theory] //pass values to a testing method
        [InlineData(20)]
        [InlineData(40)]
        [InlineData(50)]
        public void TestSetCarDoorsMethodIncorrectValues(int doors) {

            Car car = new Car();
            Xunit.Assert.Throws<Exception>( () =>  car.Doors = doors );
        
        }

    }
}
