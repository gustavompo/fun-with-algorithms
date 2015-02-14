using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Graphs;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Tests.Graphs
{
    [TestClass]
    public class BreadthFirstTest
    {
        [TestMethod]
        public void ShouldTraverse()
        {
            var algorithm = new BreadthFirst();
            var graph = GivenSampleGraph();
            var traverseResult = algorithm.Traverse(graph);
            var expected = new[] { "a", "b", "d", "e", "f", "c", "g" };
            Assert.IsTrue(expected.SequenceEqual(traverseResult));
        }

        private Graph GivenSampleGraph()
        {
            var g = new GraphElement("g", new List<GraphElement>());
            var f = new GraphElement("f", new List<GraphElement>());
            var e = new GraphElement("e", new List<GraphElement>());
            var d = new GraphElement("d", new List<GraphElement> { g });
            var c = new GraphElement("c", new List<GraphElement>());
            var b = new GraphElement("b", new List<GraphElement> { f, c });
            var a = new GraphElement("a", new List<GraphElement> { b, d, e });
            var graph = new Graph(a);
            return graph;
        }
    }
}
