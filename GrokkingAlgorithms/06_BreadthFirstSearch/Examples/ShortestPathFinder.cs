namespace _06_BreadthFirstSearch.Examples;

public class ShortestPathFinder
{
    public static void FindShortestPath(Dictionary<string, List<string>> graph, string start, string target)
    {
        var queue = new Queue<string>();
        queue.Enqueue(start);

        var visited = new HashSet<string>() { start };

        var parents = new Dictionary<string, string>();
        var found = false;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current == target)
            {
                found = true;
                break;
            }

            if (graph.ContainsKey(current))
            {
                foreach (var neighbor in graph[current])
                {
                    visited.Add(current);
                    parents[neighbor] = current;
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Reconstruct path by backtracking from end to start
        if (found)
        {
            Console.WriteLine("Path Found!");
            var path = new List<string>();
            string currentNode = target;

            while (currentNode != start)
            {
                path.Add(currentNode);
                currentNode = parents[currentNode];
            }
            path.Add(start);
            path.Reverse();

            Console.WriteLine("Shortest Path: " + string.Join(" -> ", path));
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }
}
