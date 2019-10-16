using NUnit.Framework;

namespace TestNinja.UnitTests.Exercses
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenObjectIsNull_ReturnArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenObjectIsNotNull_ReturnObjectCount()
        {
            var stack = new Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }
    }
}
