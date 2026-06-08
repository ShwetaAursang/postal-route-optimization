using System;
using System.Collections.Generic;

namespace PostalRouteOptimization
{
    public class ChinesePostman
    {
        private readonly Graph _graph;

        public ChinesePostman(Graph graph)
        {
            _graph = graph;
        }

        public void Analyze()
        {
            Console.WriteLine("=== Chinese Postman Analysis ===");

            var oddVertices = _graph.OddDegreeVertices();

            Console.WriteLine(
                $"Odd Degree Vertices: {oddVertices.Count}");

            foreach (var vertex in oddVertices)
            {
                Console.WriteLine($"Vertex {vertex}");
            }

            if (oddVertices.Count == 0)
            {
                Console.WriteLine(
                    "Graph is Eulerian. No duplication required.");
            }
            else
            {
                Console.WriteLine(
                    "Graph is not Eulerian.");

                Console.WriteLine(
                    "Additional routes required for optimization.");
            }
        }

        public int TotalDistance()
        {
            int total = 0;

            foreach (var edge in _graph.Edges)
            {
                total += edge.Weight;
            }

            return total;
        }
    }
}
