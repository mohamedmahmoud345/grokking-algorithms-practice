namespace _08_GreedyAlgorithms;

public class SetCoverGreedy
{
    public List<string> SolveSetCover(Dictionary<string, HashSet<string>> stations, HashSet<string> statesNeeded)
    {
        var finalStations = new List<string>();
        var uncovered = new HashSet<string>(statesNeeded); 

        // Keep going until every state is covered
        while (uncovered.Count > 0)
        {
            string bestStation = null!;
            var statesCoveredByBest = new HashSet<string>();

            // find the station that covers the MOST still-uncovered states
            foreach (var station in stations)
            {
                // Create a temp set: intersection of station coverage & uncovered states
                var covered = new HashSet<string>(station.Value);
                covered.IntersectWith(uncovered);

                // Track the station with the highest overlap
                if (covered.Count > statesCoveredByBest.Count)
                {
                    bestStation = station.Key;
                    statesCoveredByBest = covered;
                }
            }

            // If we found a useful station, lock it in and remove covered states
            if (bestStation != null)
            {
                finalStations.Add(bestStation);
                uncovered.ExceptWith(statesCoveredByBest);
            }
            else
            {
                break; // Safety break (shouldn't happen with valid input)
            }
        }

        return finalStations;
    }
}

