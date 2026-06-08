using System.Collections.Generic;
using System.Linq;
using PostalRouteOptimization.Models;

namespace PostalRouteOptimization
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        public List<Edge> Edges { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
            Edges = new List<Edge>();
        }

        public void AddNode(int id)
        {
            Nodes.Add(new Node(id));
        }

        public void AddEdge(int source, int destination, int weight)
        {
            Edges.Add(new Edge(source, destination, weight));
        }

        public List<Edge> GetNeighbors(int nodeId)
        {
            return Edges
                .Where(e => e.Source == nodeId || e.Destination == nodeId)
                .ToList();
        }

        public int Degree(int nodeId)
        {
            return Edges.Count(e =>
                e.Source == nodeId ||
                e.Destination == nodeId);
        }

        public List<int> OddDegreeVertices()
        {
            return Nodes
                .Where(n => Degree(n.Id) % 2 != 0)
                .Select(n => n.Id)
                .ToList();
        }
    }
}
