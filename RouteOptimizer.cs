using System;
using System.Collections.Generic;

namespace PostalRouteOptimization
{
    public class RouteOptimizer
    {
        public Dictionary<int, int> Dijkstra(Graph graph, int start)
        {
            var distances = new Dictionary<int, int>();

            foreach (var node in graph.Nodes)
            {
                distances[node.Id] = int.MaxValue;
            }

            distances[start] = 0;

            var visited = new HashSet<int>();

            while (visited.Count < graph.Nodes.Count)
            {
                int current = -1;
                int minDistance = int.MaxValue;

                foreach (var pair in distances)
                {
                    if (!visited.Contains(pair.Key) &&
                        pair.Value < minDistance)
                    {
                        current = pair.Key;
                        minDistance = pair.Value;
                    }
                }

                if (current == -1)
                    break;

                visited.Add(current);

                foreach (var edge in graph.GetNeighbors(current))
                {
                    int neighbor =
                        edge.Source == current
                        ? edge.Destination
                        : edge.Source;

                    int newDistance =
                        distances[current] + edge.Weight;

                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                    }
                }
            }

            return distances;
        }
    }
}
