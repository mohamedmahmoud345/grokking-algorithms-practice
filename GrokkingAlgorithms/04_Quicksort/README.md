# Chapter 4: Quicksort

This chapter introduces **Divide and Conquer (D&C)** , a powerful recursive problem-solving strategy, and applies it to create **Quicksort**, one of the fastest and most elegant sorting algorithms.

## 1. Divide & Conquer (D&C)

D&C is a general-purpose technique used when a problem cannot be solved by a standard algorithm. It works by breaking a problem down into smaller, simpler versions of itself.

**D&C algorithms are recursive and consist of two steps:**
1.  **Base Case:** Identify the simplest possible version of the problem.
2.  **Recursive Step:** Divide or decrease the problem until it becomes the base case.

**Examples of D&C in action:**

- **Land Division:** A farmer wants to divide a rectangular plot into the largest possible equal square plots. By applying the logic of Euclid's algorithm, you can reduce the problem into smaller and smaller rectangles until you reach a square that fits perfectly (the base case).
- **Summing an Array:** To sum numbers recursively, the base case is an array with one element (sum = that element) or an empty array (sum = 0). The recursive step involves adding the first number to the sum of the rest of the array.

## 2. The Quicksort Algorithm

Quicksort is a sorting algorithm that is significantly faster than selection sort and uses the D&C strategy.

**How it works:**

1.  **Base Case:** Arrays with a size of 0 or 1 are already "sorted" and are returned as-is.
2.  **Pick a Pivot:** Choose an element from the array. This will be the "pivot".
3.  **Partitioning:** Divide the remaining elements into two sub-arrays: those **less than** the pivot and those **greater than** the pivot.
4.  **Recurse:** Recursively call quicksort on both sub-arrays.
5.  **Combine:** Concatenate the sorted less-than array, the pivot, and the sorted greater-than array to produce the fully sorted result.

> **Note:** The implementation for this algorithm can be found in the accompanying code file.

## 3. Big O Notation and Performance

Quicksort is unique because its speed depends heavily on the pivot chosen.

- **Average and Best Case:** ***O(n log n)*** . This occurs when you split the array into two roughly equal halves at each step, resulting in a call stack height of ***O(log n)*** .
- **Worst Case:** ***O(n²)*** . This happens if the array is already sorted and you always pick the first (or last) element as the pivot. This leads to a very tall call stack where one sub-array is always empty.
- **Practical Speed:** Quicksort is often faster than merge sort (which is also ***O(n log n)*** ) in practice because it has a smaller **constant**. Big O notation usually ignores this fixed amount of time, but it matters in real-world execution.

## 4. The Importance of Pivot Selection

To consistently hit the ***O(n log n)*** average case, it is best to choose a **random element** as the pivot. This simple strategy minimizes the chance of the worst-case scenario and ensures the call stack stays at a manageable average height of ***O(log n)*** .

## Key Takeaways

- **D&C** works by breaking a problem down into smaller and smaller versions of itself until you hit a simple **base case**.
- The base case for most list-based D&C algorithms is an **empty array or an array with one element**.
- **Quicksort** is a fast sorting algorithm with an average runtime of ***O(n log n)*** .
- **Pivot choice** is the deciding factor between quicksort being highly efficient or as slow as selection sort. **Randomizing the pivot** is key to achieving great performance.
