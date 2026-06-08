public List<int> FindEulerianCircuit()
{
    Stack<int> stack = new();
    List<int> circuit = new();

    stack.Push(1);

    while (stack.Count > 0)
    {
        int current = stack.Peek();

        var edge = GetUnusedEdge(current);

        if (edge != null)
        {
            MarkUsed(edge);

            int next =
                edge.Source == current
                ? edge.Destination
                : edge.Source;

            stack.Push(next);
        }
        else
        {
            circuit.Add(stack.Pop());
        }
    }

    circuit.Reverse();

    return circuit;
}
