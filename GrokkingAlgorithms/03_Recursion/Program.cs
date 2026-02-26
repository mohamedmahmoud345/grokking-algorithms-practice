// ── 1. Anatomy of a Recursive Function ────────────────────────────
// Every recursive function needs:
//   • Base case   → stops the recursion
//   • Recursive case → the function calls itself

Console.WriteLine("=== 1. Recursive Factorial ===");
Console.WriteLine(Factorial(5)); // 5! = 120

static int Factorial(int x)
{
    if (x == 1) return 1;          // Base case
    return x * Factorial(x - 1);  // Recursive case
}

// ── 2. The Call Stack ─────────────────────────────────────────────
// Each call is pushed onto the stack; when it returns it is popped off.
// Printing depth shows the stack growing and then unwinding.

Console.WriteLine("\n=== 2. Call Stack Visualized ===");
CountdownWithStack(3, 0);

static void CountdownWithStack(int n, int depth)
{
    string indent = new string(' ', depth * 2);
    Console.WriteLine($"{indent}→ PUSH: CountdownWithStack({n})  [stack depth: {depth + 1}]");

    if (n <= 0)                    // Base case
    {
        Console.WriteLine($"{indent}  Base case reached — start unwinding");
        Console.WriteLine($"{indent}← POP:  CountdownWithStack({n})");
        return;
    }

    CountdownWithStack(n - 1, depth + 1);  // Recursive case

    Console.WriteLine($"{indent}← POP:  CountdownWithStack({n})");
}

// ── 3. Stack Overflow Warning (page 42) ─────────────────────────────────────
// A function with NO base case will recurse forever → StackOverflowException.
// Do NOT call InfiniteRecursion() — it is here only to illustrate the concept.

// static void InfiniteRecursion()
// {
//     InfiniteRecursion(); // No base case → stack fills up → crash!
// }

// ── 4. Iterative Alternative (page 43) ──────────────────────────────────────
// Loops can replace recursion and use constant memory (no stack growth).

Console.WriteLine("\n=== 3. Iterative Factorial (same result, no stack growth) ===");
Console.WriteLine(FactorialIterative(5)); // 120

static int FactorialIterative(int x)
{
    int result = 1;
    for (int i = 2; i <= x; i++)
        result *= i;
    return result;
}