# Chapter 6: Breadth-First Search (BFS)

This chapter introduces **graphs** and the **Breadth-First Search (BFS)** algorithm. BFS is a fundamental algorithm used to find the shortest distance between two points in an unweighted graph.

## Key Concepts

### 1. What is a Graph?

A graph models a set of connections. It consists of:

- **Nodes**: The entities in the graph (e.g., people, cities, web pages).
- **Edges**: The lines connecting the nodes (representing relationships like friendship, roads, or links).

Graphs are used to solve "connectivity" problems, such as:

- Is there a path from node A to node B?
- What is the shortest path from node A to node B?

### 2. Breadth-First Search (BFS)

BFS is an algorithm that answers two questions:

1. **Is there a path?** (e.g., Is there a mango seller in my network?)
2. **What is the shortest path?** (e.g., Who is the closest mango seller?)

BFS explores the graph in "layers":

1. First, it checks all immediate neighbors (1st-degree connections).
2. If the target isn't found, it checks the neighbors of those neighbors (2nd-degree connections).
3. This ensures that if a solution is found, it is reached via the fewest number of edges.

### 3. Queues (FIFO)

BFS relies on a **Queue** data structure to track which nodes to search next.

- **FIFO (First In, First Out)**: The first item added is the first one processed.
- This is essential for BFS because we must check people in the order they were added to ensure we find the *shortest* path (checking 1st-degree connections before 2nd-degree ones).

### 4. Big O Notation

The running time of BFS is **O(V + E)**.

- **V (Vertices)**: The number of nodes (people) to add to the queue.
- **E (Edges)**: The number of connections (edges) to follow.

### 5. Directed vs. Undirected Graphs

- **Directed Graph (Digraph)**: Relationships are one-way (e.g., Alice -> Bob). An arrow points from one node to another.
- **Undirected Graph**: Relationships are two-way (e.g., Alice -- Bob). An undirected edge is equivalent to two directed edges pointing at each other.
