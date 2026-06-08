namespace PostalRouteOptimization.Models
{
    public class Node
    {
        public int Id { get; set; }

        public Node(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Node {Id}";
        }
    }
}
