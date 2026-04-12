# CommandSystem

A lightweight, high-performance command processing library for C# applications.

## 🚀 Getting Started

### Installation
You can quickly integrate the library into your project by downloading the latest compiled version:
1. Go to the [Releases](https://github.com/AlexeyVanilov/MintCloud/releases) section.
2. Download the `CommandSystem.dll`.
3. Add the DLL as a **Reference** (dependency) in your C# project.

### Learn by Example
The best way to understand how to use the library is to check out our sample implementation.
* Explore [Examples/Program.cs](Examples/Program.cs) to see how to register commands, handle logic, and run a command loop.

## 🛠 Key Features

* **Fast Lookup:** Uses `Dictionary` with `OrdinalIgnoreCase` for $O(1)$ command retrieval.
* **Performance Optimized:** Leverages `MethodImplOptions.AggressiveInlining` and `Array.Copy` to minimize overhead and GC pressure.
* **Clean Architecture:** Strict separation between `CommandManager` (storage) and `CommandProcessor` (logic).
