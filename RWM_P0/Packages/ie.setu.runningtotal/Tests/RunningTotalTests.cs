using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class RunningTotalTests
    {
        [Test]
        public void RunningTotalSimple()
        {
            int[] input = { 4, 2, 8, 3, 9 };
            int[] output = RunningTotal.runningTotals(input);
            int[] expected = { 4, 6, 14, 17, 26};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
