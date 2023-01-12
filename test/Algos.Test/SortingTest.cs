using Algos.Algorithmes;

namespace Algos.Test;

[TestClass]
public class SortingTest
{
    [TestMethod]
    public void InsertionSortAsc_Test()
    {
        int[] array = new int[] { 5, 7, 0, -5, 3, 9 };
        int[] expectedArray = new int[] {-5, 0, 3, 5, 7, 9 };

        var sortedArray = array.InsertionSortAsc();

        Assert.IsTrue(expectedArray.SequenceEqual(sortedArray));
    }

    [TestMethod]
    public void InsertionSortDesc_Test()
    {
        int[] array = new int[] { 5, -5, 3, 7, 0, -5, 3, 9, 0 };
        int[] expectedArray = new int[] { 9, 7, 5, 3, 3, 0, 0, -5, -5 };

        var sortedArray = array.InsertionSortDesc();

        Assert.IsTrue(expectedArray.SequenceEqual(sortedArray));
    }
}