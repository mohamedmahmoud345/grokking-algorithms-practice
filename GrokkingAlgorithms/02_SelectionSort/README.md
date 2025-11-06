📚 Chapter Summary
1. How Memory Works: Arrays vs. Linked Lists
Before diving into sorting, we need to understand how data is stored in memory.

Memory as a Giant Chest of Drawers: Think of computer memory as a vast array of numbered drawers (addresses), each capable of holding one piece of data.

Arrays require contiguous (next-to-each-other) memory blocks.

Pros: Fast reads with an index (O(1) time).

Cons: Slow inserts, as you may need to shift all subsequent elements or copy the entire array to a new location if there's no space.

Linked Lists consist of elements that can be anywhere in memory. Each element stores the address of the next one (a "pointer").

Pros: Fast inserts, as you just change what the previous element points to.

Cons: Slow reads, as you must start at the first element and traverse the list sequentially (O(n) time).

Operation	Arrays	Linked Lists
Reading	O(1)	O(n)
Insertion	O(n)	O(1)
Deletion	O(n)	O(1)
2. Selection Sort: The Algorithm
The goal is to sort a list (e.g., from smallest to largest).

The Core Idea:

Find the smallest element in the list.

Remove it and add it to the beginning of a new, sorted list.

Repeat step 1 for the remaining elements, adding the next smallest to the end of the new list.

In-Place Implementation (to save memory):
Instead of creating a new list, we keep track of the current smallest element and swap it with the first unsorted element.

Steps:

Start with the first element as the current minimum.

Scan the rest of the list. If you find a smaller element, that becomes the new current minimum.

After scanning the entire list, swap the current minimum with the first element. The list is now partially sorted.

Move to the next position and repeat the process for the remaining unsorted part of the list.

3. Big O Notation Revisited
We use Big O Notation to describe the running time of an algorithm.

Selection Sort Runtime: O(n²)

Why? You have to check n elements to find the smallest, then n-1 elements, then n-2, and so on.

This results in roughly n * (n/2) checks, which Big O simplifies to O(n²).

What O(n²) Means: The run time grows very rapidly as the input size n increases. It's considered a "slow" algorithm.

💻 Example: Selection Sort in Action
Let's sort [5, 3, 6, 2, 10]

Pass 1:

Find min in entire list: 2

Swap with first element (5).

Result: [2, 3, 6, 5, 10] (Sorted part: [2])

Pass 2:

Find min in [3, 6, 5, 10]: 3

It's already in the correct position.

Result: [2, 3, 6, 5, 10] (Sorted part: [2, 3])

Pass 3:

Find min in [6, 5, 10]: 5

Swap with 6.

Result: [2, 3, 5, 6, 10] (Sorted part: [2, 3, 5])

Pass 4:

Find min in [6, 10]: 6

It's already in the correct position.

Final Sorted List: [2, 3, 5, 6, 10]

🗝️ Key Takeaways
Data Structures Matter: Your choice between an array and a linked list depends on which operations (read vs. insert/delete) are most common.

Selection Sort is a simple but inefficient (O(n²)) sorting algorithm.

Big O O(n²) is a red flag for performance on large datasets. We will learn much faster algorithms later!
