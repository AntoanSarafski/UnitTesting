using NUnit.Framework;
using Cars;

namespace Cars.Test
{
    public class CarTests
    {
        [Test]
        public void When_Car_Is_Drive_Mileage_Should_Increase() // or Test_Drive_Car_Should_Increase_Mileage()
        {
            Car car = new Car();

            car.Drive(100);

            Assert.AreEqual(car.Mileage, 100);
        }
    }
}