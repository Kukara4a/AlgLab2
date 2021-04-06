using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AlgorithmsLab2
{
    [TestFixture]
    class Tests1
    {
        [Test]
        public void EmptyString()
        {
            var list = new List<string>() { "a" };
            RadixSorting.Sorting(list, 1, 1);
            Assert.IsNotEmpty(list);
            Assert.Equals(1, 1);
        }
    }
}
