using Algos.Algorithmes;

namespace Algos.Test;

[TestClass]
public class SortingTest
{
    [TestMethod]
    public void InsertionSort_Test()
    {
        int[] array = new int[] { 5, 7, 0, -5, 3, 9 };
        int[] expectedArray = new int[] {-5, 0, 3, 5, 7, 9 };

        var sortedArray = array.InsertionSort();

        // CollectionAssert.AreEqual(expectedArray, sortedArray);
        Assert.IsTrue(expectedArray.SequenceEqual(sortedArray));
    }
}