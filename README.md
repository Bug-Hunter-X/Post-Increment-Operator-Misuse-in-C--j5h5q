# Post-Increment Operator Misuse in C# Example

This repository demonstrates a common mistake when using the post-increment operator (`++`) in C#. The post-increment operator increments the value *after* the expression is evaluated, which can lead to unexpected results if not understood properly.

## Bug Description
The bug lies in the `MyMethod` function. `Console.WriteLine(MyProperty++)` prints the *current* value of `MyProperty` before incrementing it. If you intend to print the incremented value, the pre-increment operator (`++MyProperty`) should be used.

## Solution
The solution involves replacing `MyProperty++` with `++MyProperty` to achieve the desired behavior of printing the incremented value.
