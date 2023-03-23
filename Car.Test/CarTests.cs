using NUnit.Framework;
using Cars;
using System;

namespace Cars.Test
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car();
            for (int i = 0; i < 5; i++)
            {
                car.Drive(100);
            }
        }

        [TearDown]
        public void CleanUp()
        {
            car.Mileage = 0;
        }

        [Test]
        public void When_Car_Is_Drive_Mileage_Should_Increase() // or Test_Drive_Car_Should_Increase_Mileage()
        {
            Assert.That(car.Mileage, Is.EqualTo(500));

            //Car car = new Car();
            //car.Drive(100);
            //Assert.AreEqual(100, car.Mileage);
            //Assert.True(100 == car.Mileage);
            //Assert.False(100 != car.Mileage);
            //Assert.That(car.Mileage, Is.EqualTo(100));
            //Assert.AreEqual(101, car.Mileage, "Don't lie! ;d");
            
        }

        [Test]
        public void When_Car_Is_Drive_Mileage_Should_Throw_Error_With_Negative_kms() // or Test_Drive_Car_Should_Increase_Mileage()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Drive(-100);
            });
            

        }
    }
}