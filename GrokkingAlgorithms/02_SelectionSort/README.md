# Grokking Algorithms - Chapter 2: Selection Sort

This chapter introduces fundamental concepts for analyzing algorithms and presents our first sorting algorithm: **Selection Sort**.

## Chapter Summary

### 1. How Memory Works: Arrays vs. Linked Lists

**Memory as a Giant Chest of Drawers:** Think of computer memory as a vast array of numbered drawers (addresses).

**Arrays:**
- Require contiguous memory blocks
- **Pros:** Fast reads with index (O(1) time)
- **Cons:** Slow inserts, may need to shift elements

**Linked Lists:**
- Elements can be anywhere in memory
- **Pros:** Fast inserts (O(1) time)
- **Cons:** Slow reads, must traverse sequentially (O(n) time)

| Operation | Arrays | Linked Lists |
|-----------|--------|--------------|
| Reading | O(1) | O(n) |
| Insertion | O(n) | O(1) |
| Deletion | O(n) | O(1) |

### 2. Selection Sort Algorithm

**Core Idea:**
1. Find smallest element in the list
2. Remove and add to new sorted list
3. Repeat for remaining elements

**In-Place Implementation:**
1. Start with first element as current minimum
2. Scan rest of list for smaller element
3. Swap current minimum with first unsorted element
4. Repeat for remaining unsorted portion

### 3. Big O Notation

**Selection Sort Runtime:** O(n²)
- Must check n elements, then n-1, then n-2...
- Runtime grows rapidly with input size
- Considered a "slow" algorithm

## Example: Selection Sort in Action

Sorting [5, 3, 6, 2, 10]:

**Pass 1:** Find min (2), swap with 5 → [2, 3, 6, 5, 10]
**Pass 2:** Find min in remaining (3), already in place → [2, 3, 6, 5, 10]  
**Pass 3:** Find min in remaining (5), swap with 6 → [2, 3, 5, 6, 10]
**Pass 4:** Find min in remaining (6), already in place → [2, 3, 5, 6, 10]

## Key Takeaways

- **Data Structures Matter:** Choose based on common operations
- **Selection Sort:** Simple but inefficient (O(n²))
- **Big O O(n²):** Poor performance on large datasets

---
[← Chapter 1: Introduction]([Chapter01.md](https://github.com/mohamedmahmoud345/grokking-algorithms-practice/blob/main/GrokkingAlgorithms/01_BinarySearch/README.md)) | [Chapter 3: Recursion →](Chapter03.md)

