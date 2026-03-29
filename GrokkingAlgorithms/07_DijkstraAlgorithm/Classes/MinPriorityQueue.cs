namespace _07_DijkstraAlgorithm.Classes;

public class MinPriorityQueue
{
    public static void Run(Dictionary<string, Dictionary<string, int>> graph)
    {
        var costs = new Dictionary<string, int>();
        foreach (var node in graph.Keys)
        {
            costs[node] = int.MaxValue;
        }
        costs["start"] = 0;

        var parents = new Dictionary<string, string>();

        var pq = new PriorityQueue<string, int>();
        pq.Enqueue("start", 0);

        string target = "fin";
        var found = false;

        while (pq.Count > 0)
        {
            var currentNode = pq.Dequeue();
            var currnetCost = costs[currentNode];

            if (currentNode == target)
            {
                found = true;
                break;
            }

            if (currnetCost > costs[currentNode])
            {
                continue;
            }

            if (graph.ContainsKey(currentNode))
            {
                foreach (var neighbor in graph[currentNode])
                {
                    var neighborNode = neighbor.Key;
                    var weight = neighbor.Value;

                    int newCost = weight + currnetCost;

                    if (newCost < costs[neighborNode])
                    {
                        costs[neighborNode] = newCost;
                        parents[neighborNode] = currentNode;

                        pq.Enqueue(neighborNode, newCost);
                    }
                }
            }
        }
        if (found)
        {
            Console.WriteLine($"Shortest path found! Total Cost: {costs[target]}");

            var path = new List<string>();
            string curr = target;

            while (curr != "start")
            {
                path.Add(curr);
                if (!parents.ContainsKey(curr))
                    break;
                curr = parents[curr];
            }
            path.Add("start");
            path.Reverse();

            Console.WriteLine("Path: " + string.Join(" -> ", path));
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }
}
