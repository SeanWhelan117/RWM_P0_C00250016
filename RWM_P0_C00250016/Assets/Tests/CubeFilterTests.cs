using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };
            CollectionAssert.AreEqual(expected, output);
        }
    }
}

