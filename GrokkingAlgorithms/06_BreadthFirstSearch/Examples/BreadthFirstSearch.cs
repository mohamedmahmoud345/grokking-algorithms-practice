namespace _06_BreadthFirstSearch.Examples;

class BreadthFirstSearch
{
    public static void FindSeller(Dictionary<string, List<string>> graph)
    {
        var searchQueue = new Queue<string>();
        var set = new HashSet<string>();

        foreach (var friend in graph["you"])
        {
            searchQueue.Enqueue(friend);
        }

        while (searchQueue.Count > 0)
        {
            var person = searchQueue.Dequeue();

            if (IsSeller(person))
            {
                Console.WriteLine($"{person} is a mango seller!");
                return;
            }
            else
            {
                if (graph.ContainsKey(person))
                {
                    foreach (var friend in graph[person])
                    {
                        searchQueue.Enqueue(person);
                    }
                }
                set.Add(person);
            }
            Console.WriteLine("No mango seller found!");
            return;
        }
    }
    private static bool IsSeller(string name)
    {
        return name.EndsWith('m');
    }
}
