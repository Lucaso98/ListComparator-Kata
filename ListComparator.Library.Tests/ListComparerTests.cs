using NUnit.Framework;

namespace ListComparator.Library.Tests
{
    [TestFixture]
    public class ListComparerTests
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 5, 4, 8 }, 4)]
        [TestCase(new[] { 5, 6, 7, 8, 9 }, new[] { 5, 6, 7, 10, 11 }, 3)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 0)]
        public void Test_ReturnAmountOfElementsThatAreSameIn2Arrays(int[] arr1, int[] arr2, int expected)
        {
            var listComparator = new ListComparer();

            var actual = listComparator.Compare(arr1, arr2);

            Assert.AreEqual(expected, actual);
        }
    }
}
