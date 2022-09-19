using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementiflessthanfirstTest
    {
        [Test]
        public void DecrementiflessthanfirstSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = DecrementiflessthanfirstFilter.cubes(input);
            int[] expected = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };
            CollectionAssert.AreEqual(expected, output);
        }
    }
}

