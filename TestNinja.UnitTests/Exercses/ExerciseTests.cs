using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Exercses
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberNotDivisionalBy3Or5_ReturnsInputNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
