# Chapter 3: Recursion

Recursion is a foundational programming technique where a function calls itself. It often makes code more elegant and easier to read, though it doesn't always outperform traditional loops in terms of efficiency.

---

## 📌 1. Anatomy of a Recursive Function

Every recursive function must have two essential parts:

| Component | Description |
|-----------|-------------|
| **Recursive Case** | The part of the function where it calls itself to continue the operation |
| **Base Case** | The condition that stops the recursion. Without a base case, the function will run forever and eventually crash |

---

## 📌 2. Understanding the Stack

The **stack** is a simple **Last In, First Out (LIFO)** data structure with two main operations:


### PUSH → Add a new item to the top of the stack
### POP → Remove and read the topmost item
---

## 📌 3. The Call Stack

Computers manage function calls using an internal structure called the **call stack**:

- 🔹 When a function is called, memory is allocated for that call and **pushed** onto the stack
- 🔹 If a function calls another function, the first one is **paused** until the second returns
- 🔹 Once a function completes, its memory block is **popped** off the stack, and execution resumes where it left off
Stack Visualization:
-------------------
    funcC()     ← Top (most recent)
    funcB()
    funcA()
    main()      ← Bottom (first called)
-------------------

---

## 📌 4. Recursion and Memory

Recursive functions rely heavily on the call stack:

| Aspect | Description |
|--------|-------------|
| **Memory Overhead** | Each recursive call consumes memory for its variables |
| **Stack Overflow** | If recursion runs too long or lacks a base case, the stack fills up and the program crashes |
| **Alternatives** | Loops or tail recursion (in some languages) can reduce memory usage |

---

## ✅ Key Takeaways

> 📝 **Recursion** = a function calling itself

> ⚡ Every recursive function needs a **base case** and a **recursive case**

> 🥞 The **call stack** is a LIFO structure that tracks active functions

> ⚠️ Too many recursive calls → **StackOverflowError**

> 💡 **Iterative solutions** (loops) are often safer when memory is a concern

---

*"To understand recursion, you must first understand recursion."* 🔄