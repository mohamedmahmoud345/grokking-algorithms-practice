using _06_BreadthFirstSearch.Examples;

// 1. Breadth first search 
var graph1 = new Dictionary<string, List<string>>
        {
            { "you", new List<string> { "alice", "bob", "claire" } },
            { "bob", new List<string> { "anuj", "peggy" } },
            { "alice", new List<string> { "peggy" } },
            { "claire", new List<string> { "thom", "jonny" } },
            { "anuj", new List<string>() },
            { "peggy", new List<string>() },
            { "thom", new List<string>() },
            { "jonny", new List<string>() }
        };

Console.WriteLine("------ Breadth first search ------");
BreadthFirstSearch.FindSeller(graph1);


Console.WriteLine("------ shortest path finder ------");
var graph2 = new Dictionary<string, List<string>>
        {
            { "start", new List<string> { "a", "b" } },
            { "a", new List<string> { "c" } },
            { "b", new List<string> { "c", "d" } },
            { "c", new List<string> { "end" } },
            { "d", new List<string> { "e" } },
            {"e", new List<string>{"end"}},
            { "end", new List<string>() }
        };

ShortestPathFinder.FindShortestPath(graph2, "start", "end");

