# Chapter 5: Hash Tables

This chapter explores hash tables, one of the most practical and frequently used data structures in computer science. They allow for nearly instantaneous data retrieval by mapping keys directly to values.

## 1. How Hash Tables Work

A hash table is built by combining a hash function with an array.

**Hash Functions:** A function that "maps strings to numbers". When you provide a string (key), the function returns a specific index in an array where the value should be stored.

**Requirements for a Good Hash Function:**
- **Consistency:** The same input must always produce the same output.
- **Uniqueness:** It should map different inputs to different indices to minimize overlap.
- **Efficiency:** It should return valid indices within the range of the table's array.

## 2. Practical Use Cases

Hash tables (known as `dict` in Python, or `Dictionary` in C#) are used for:

- **Lookups:** Rapidly retrieving a value associated with a key, such as looking up a price in a grocery store or finding a phone number by name.
- **DNS Resolution:** Mapping website URLs (like google.com) to IP addresses.
- **Preventing Duplicates:** Instantly checking if an item already exists in a set, such as a list of voters at a polling station.
- **Caching:** Storing the results of expensive calculations or web requests so the server doesn't have to recalculate them every time.

## 3. Collisions and Performance

A **collision** occurs when two different keys map to the same index in the hash table.

**Handling Collisions:** The simplest method is to start a linked list at that specific index. However, if the linked list becomes too long, it slows the table down.

**Time Complexity:**
- **Average Case:** O(1) (Constant Time) for search, insert, and delete.
- **Worst Case:** O(n) (Linear Time), which happens if many keys collide in a single slot.

## 4. Load Factor and Resizing

The **load factor** is the ratio of the number of items in the table to the total number of slots.

- **Rule of Thumb:** You should resize your hash table when the load factor is greater than 0.7.
- **Resizing:** To maintain O(1) performance, the table creates a new, larger array (usually double the size) and re-hashes every existing item into the new slots.

## Key Takeaways

- Hash tables use keys and values to model relationships between data.
- They are incredibly fast, offering O(1) average performance for search, insert, and delete.
- A good hash function is essential to distribute data evenly and avoid collisions.
- Resizing is necessary once the table gets too full to maintain its speed.