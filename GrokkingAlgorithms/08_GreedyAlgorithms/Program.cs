using _08_GreedyAlgorithms;


var statesNeeded = new HashSet<string>
{ "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };

var stations = new Dictionary<string, HashSet<string>>
{
    ["kone"] = new HashSet<string> { "id", "nv", "ut" },
    ["ktwo"] = new HashSet<string> { "wa", "id", "mt" },
    ["kthree"] = new HashSet<string> { "or", "nv", "ca" },
    ["kfour"] = new HashSet<string> { "nv", "ut" },
    ["kfive"] = new HashSet<string> { "ca", "az" }
};



var setCover = new SetCoverGreedy();

var result = setCover.SolveSetCover(stations, statesNeeded);

Console.WriteLine("Selected stations: " + string.Join(" ", result));
