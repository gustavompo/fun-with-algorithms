using Algorithms.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.Graphs
{
    [TestClass]
    public class DepthFirstTest
    {

        [TestMethod]
        public void ShouldTraverse()
        {
            var graph = GivenSampleGraph();
            var depthFirst = new DepthFirst();
            var result = depthFirst.Traverse(graph);
            var expected = new[] { "a", "b", "f", "c", "d", "g", "e" };
            Assert.IsTrue(expected.SequenceEqual(result));
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
