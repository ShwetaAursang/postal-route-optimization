[TestMethod]
public void TestTotalDistance()
{
    Graph graph = new Graph();

    graph.AddNode(1);
    graph.AddNode(2);

    graph.AddEdge(1, 2, 10);

    ChinesePostman cpp =
        new ChinesePostman(graph);

    Assert.AreEqual(
        10,
        cpp.TotalDistance()
    );
}
