using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graphs
{
    public class DepthFirst
    {
        private List<string> _result;

        public IEnumerable<string> Traverse(Graph graph)
        {
            Init();
            Traverse(graph.Root);
            return _result;
        }

        private void Init()
        {
            _result = new List<string>();
        }

        private void Traverse(GraphElement element)
        {
            _result.Add(element.Value);
            foreach (var el in element.Connections)
            {
                if (!_result.Contains(el.Value))
                {
                    Traverse(el);
                }
            }
                
        }

    }
}
