using _07_DijkstraAlgorithm.Classes;

// 1. difne the graph 
var graph = new Dictionary<string, Dictionary<string, int>>
{
    { "start", new Dictionary<string, int> { { "a", 6 }, { "b", 2 } } },
    { "a",     new Dictionary<string, int> { { "fin", 1 } } },
    { "b",     new Dictionary<string, int> { { "a", 3 }, { "fin", 5 } } },
    { "fin",   new Dictionary<string, int>() }
};

// 2. initialize costs
var costs = new Dictionary<string, int>
{
    {"a", 6},
    {"b", 2},
    {"fin", int.MaxValue}
};

// 3. initialize parents
var parents = new Dictionary<string, string>
{
    {"a", "start"},
    {"b", "start"},
    {"fin", null}
};

Console.WriteLine("=========== using dijkstra ===========");
Dijkstra.Run(graph, costs, parents);


Console.WriteLine("=========== using MinPriorityQueue ===========");
MinPriorityQueue.Run(graph);