﻿using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Sort
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void ShouldSortTwo()
        {
            var input = new[] { 1,0 };
            MergeSort.Sort(input);
            Assert.IsTrue(new[] { 0,1 }.SequenceEqual(input));
        }
        
        [TestMethod]
        public void ShouldSort()
        {
            var input = new[] { 5, 7, 8, 1, 2, 6 };
            MergeSort.Sort(input);
            Assert.IsTrue(new[] { 1, 2, 5, 6, 7, 8 }.SequenceEqual(input));
        }

        [TestMethod]
        public void ShouldSortWithDuplicates()
        {
            var input = new[] { 5, 7, 8, 1, 2, 6, 6, 6, 8, 0 };
            MergeSort.Sort(input);
            Assert.IsTrue(new[] { 0, 1, 2, 5, 6, 6, 6, 7, 8, 8 }.SequenceEqual(input));
        }
    }
}
