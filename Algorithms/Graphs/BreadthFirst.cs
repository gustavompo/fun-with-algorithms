using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graphs
{
    public class Graph
    {
        public Graph(GraphElement root)
        {
            this.Root = root;
        }
        public GraphElement Root { get; private set; }
    }
    public class GraphElement
    {
        public GraphElement(string value, IEnumerable<GraphElement> connections)
        {
            this.Value = value;
            this.Connections = connections;
        }
        public IEnumerable<GraphElement> Connections { get; private set; }
        public string Value { get; private set; }
    }

    public class BreadthFirst
    {
        private Queue<GraphElement> _nextElements;
        private List<string> _result;

        private void Init()
        {
            _nextElements = new Queue<GraphElement>();
            _result = new List<string>();
        }
        public IEnumerable<string> Traverse(Graph graph)
        {
            Init();
            Traverse(graph.Root);
            return _result;
        }

        private void Traverse(GraphElement element)
        {
            _result.Add(element.Value);
            foreach(var el in element.Connections){
                if (!_result.Contains(el.Value))
                {
                    _nextElements.Enqueue(el);
                }
            }
            if (_nextElements.Count > 0)
            {
                Traverse(_nextElements.Dequeue());
            }
            
        }
    }
}
