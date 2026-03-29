namespace _07_DijkstraAlgorithm.Classes;

public class Dijkstra
{
    public static void Run(Dictionary<string, Dictionary<string, int>> graph, Dictionary<string, int> costs, Dictionary<string, string> parents)
    {
        var processed = new List<string>();

        var node = FindLowestCostNode(costs, processed);

        while (node != null)
        {
            int cost = costs[node];
            var neighbors = graph[node];

            foreach (var neighbor in neighbors)
            {
                var nKey = neighbor.Key;
                var weight = neighbor.Value;

                int newCost = cost + weight;

                if (newCost < costs[nKey])
                {
                    costs[nKey] = newCost;
                    parents[nKey] = node;
                }
            }
            processed.Add(node);
            node = FindLowestCostNode(costs, processed);
        }
        
        Console.WriteLine($"Shortest Cost to Fin: {costs["fin"]}");

        // Reconstruct Path
        var path = new List<string>();
        string current = "fin";

        while (current != null && current != "start")
        {
            path.Add(current);
            if (parents.ContainsKey(current))
                current = parents[current];
            else
                break;
        }
        path.Add("start");
        path.Reverse();

        Console.WriteLine("Path: " + string.Join(" -> ", path));
    }
    private static string FindLowestCostNode(Dictionary<string, int> costs, List<string> processed)
    {
        var lowestCost = int.MaxValue;
        string lowestNode = null;

        foreach (var kvp in costs)
        {
            var node = kvp.Key;
            var cost = kvp.Value;

            if (cost < lowestCost && !processed.Contains(node))
            {
                lowestCost = cost;
                lowestNode = node;
            }
        }

        return lowestNode!;
    }
}
