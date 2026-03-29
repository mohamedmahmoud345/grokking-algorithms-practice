## Chapter 7: Dijkstra's Algorithm

### What It Solves

Finds the shortest path in a weighted graph where all edges have non‑negative numbers.

### Key Concept

Instead of exploring all paths equally (like breadth‑first search), Dijkstra's algorithm always expands the cheapest node first.

### How It Works (Step by Step)

1. Keep track of the cheapest known cost to reach each node.
2. Pick the unprocessed node with the lowest total cost.
3. Update the costs of its neighbors if going through this node is cheaper.
4. Mark the node as processed (never revisit it).
5. Repeat until all nodes are processed.

### What You Track

- **Costs table** – shortest known distance to each node.
- **Parents table** – which node gave you that best path.
- **Processed list** – nodes already finalized.

### Important Limitation

**Does not work with negative weights.**  
If a graph has negative edges, Dijkstra may lock in a wrong path too early. Use the Bellman‑Ford algorithm instead.

### Real‑World Examples

- GPS devices calculating fastest driving routes
- Network routing protocols (OSPF)
- Video games for enemy movement or pathfinding

### Trade‑offs Compared to BFS

| Breadth‑First Search (BFS) | Dijkstra's Algorithm |
|----------------------------|----------------------|
| Unweighted graphs only | Weighted graphs |
| Fewer steps | More steps |
| Can't handle costs | Optimizes for lowest total cost |

### One‑Sentence Takeaway
>
> Dijkstra finds the most efficient path in a weighted graph, as long as no edge has a negative weight.
