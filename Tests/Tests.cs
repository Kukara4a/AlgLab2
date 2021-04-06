using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLab2
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void IsNotEmptyString()
        {
            var list = new List<string>() { "a" };
            RadixSorting.Sorting(list, 1, 1);
            Assert.IsNotEmpty(list);

            var list1 = new List<string>() { "dhtyrogktofnthe" };
            RadixSorting.Sorting(list1, 15, 26);
            Assert.IsNotEmpty(list1);

            var list2 = new List<string>() { "a", "a", "a" };
            RadixSorting.Sorting(list2, 1, 1);
            Assert.IsNotEmpty(list2);
        }

        [Test]
        public void MultipleIdenticalElements()
        {
            var list = new List<string>() { "a", "a", "a" };
            RadixSorting.Sorting(list, 1, 1);
            Assert.AreEqual(new List<string>() { "a", "a", "a" }, list);

            var list1 = new List<string>() { "abc", "abc", "abc" };
            RadixSorting.Sorting(list1, 3, 3);
            Assert.AreEqual(new List<string>() { "abc", "abc", "abc" }, list1);
        }

        [Test]
        public void ListInDescendingOrder()
        {
            var list = new List<string>() { "d", "c", "b", "a" };
            RadixSorting.Sorting(list, 1, 4);
            Assert.AreEqual(new List<string>() { "a", "b", "c", "d" }, list);

            var list1 = new List<string>() { "dfsdfsdf", "bbbbbbb", "a" };
            RadixSorting.Sorting(list1, 8, 26);
            Assert.AreEqual(new List<string>() { "a", "bbbbbbb", "dfsdfsdf" }, list1);
        }

        [Test]
        public void RandomList()
        {
            var letters = "qwertyuiopasdfghjklzxcvbnm";
            var list = new List<string>();
            int maxLen = -1;

            for (int i = 0; i < new Random().Next(1, 20); i++)
            {
                var a = new Random().Next(1, 20);
                if (a > maxLen) maxLen = a;

                list.Add(""); 

                for (int j = 0; j < a; j++)               
                    list[i] += letters[new Random().Next(0, 26)];                
            }

            var expected = new List<string>(list);
            expected.Sort();

            RadixSorting.Sorting(list, maxLen, 26);

            Assert.AreEqual(expected, list);
        }

        [Test]
        public void DifferentSetsOfValues()
        {
            var list = new List<string>() { "cc", "aa", "bb", "cc", "abc", "cbd" };
            var expected = new List<string>(list);

            RadixSorting.Sorting(list, 3, 4);
            expected.Sort();

            Assert.AreEqual(expected, list);

            var list1 = new List<string>() { "aaaaaaa", "aaaaa", "aaa", "a" };
            RadixSorting.Sorting(list1, 7, 1);
            Assert.AreEqual(new List<string>() { "aaaaaaa", "aaaaa", "aaa", "a" }, list1);
        }
    }
}
