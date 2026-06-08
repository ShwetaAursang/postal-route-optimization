using System;

namespace PostalRouteOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddNode(4);

            graph.AddEdge(1, 2, 10);
            graph.AddEdge(2, 3, 15);
            graph.AddEdge(3, 4, 20);
            graph.AddEdge(4, 1, 25);
            graph.AddEdge(1, 3, 30);

            ChinesePostman cpp =
                new ChinesePostman(graph);

            cpp.Analyze();

            Console.WriteLine();

            Console.WriteLine(
                $"Total Network Distance: {cpp.TotalDistance()} km");

            RouteOptimizer optimizer =
                new RouteOptimizer();

            var shortest =
                optimizer.Dijkstra(graph, 1);

            Console.WriteLine();
            Console.WriteLine(
                "Shortest Paths From Node 1");

            foreach (var route in shortest)
            {
                Console.WriteLine(
                    $"To Node {route.Key}: {route.Value} km");
            }
        }
    }
}
