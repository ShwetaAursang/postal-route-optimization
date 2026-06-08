using System.IO;
using System.Text.Json;

public static class GraphLoader
{
    public static Graph Load(string path)
    {
        string json = File.ReadAllText(path);

        GraphData data =
            JsonSerializer.Deserialize<GraphData>(json);

        Graph graph = new Graph();

        foreach (int node in data.Nodes)
            graph.AddNode(node);

        foreach (var edge in data.Edges)
            graph.AddEdge(
                edge.Source,
                edge.Destination,
                edge.Weight
            );

        return graph;
    }
}
