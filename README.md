# NullReferenceException in C# with Value Type Property

This repository demonstrates a potential `NullReferenceException` in C# that can occur when accessing a value type property that hasn't been explicitly initialized.  Value types in C# (like `int`, `float`, etc.) are different than reference types. While they cannot be directly null, a class containing a value type property can have that property implicitly initialized to its default (0 for integers, false for booleans, etc.).  However, certain operations on such properties can still unexpectedly throw a `NullReferenceException`.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file illustrates how to prevent this exception.