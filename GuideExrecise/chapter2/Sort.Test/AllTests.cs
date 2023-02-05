using NUnit.Framework;
using System.Collections.Generic;

namespace Sort.Test
{
    /// <summary>
    ///ChatGPT generated
    /// </summary>
	public class Tests
    {

    [TestFixture]
        public class UnitTests
        {
            [TestCase(new int[] { 5, 4, 3, 2 }, new int[] { 2, 3, 4, 5 })]
            [TestCase(new int[] { 1, 2, 3, 4,2, 5 }, new int[] { 1, 2,2, 3, 4, 5 })]
            [TestCase(new int[] { 5, 1, 4, 2, 3 }, new int[] { 1, 2, 3, 4, 5 })]
            [TestCase(new int[] { 3, 2, 5, 4, 1 }, new int[] { 1, 2, 3, 4, 5 })]
            [TestCase(new int[] { 1, 5, 2, 4, 3 }, new int[] { 1, 2, 3, 4, 5 })]
            [TestCase(new int[] { 5, 4, 3, 2, 1, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
            [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6 })]
            [TestCase(new int[] { 3, 1, 4, 2, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
            [TestCase(new int[] { 1, 6, 2, 5, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 })]
            [TestCase(new int[] { 6, 1, 5, 2, 4, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
            public void BubbleSort_Sort_ReturnsSortedArray(int[] input, int[] expected)
            {
                // Arrange

                // Act
                int[] result = Program.QuickSort(new List<int>(input)).ToArray();

                // Assert
                Assert.AreEqual(expected, result);
            }
        }
    }
}