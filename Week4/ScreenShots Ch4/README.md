1. While Loop (Correct Usage)
  Concept: Executes a block of statements repeatedly as long as a given condition remains true.
  How It Works: Checks the condition first before running the inner statement. An explicit increment or state update is included inside the loop body to ensure it terminates properly after reaching the limit.

2. For Loop
   Concept: Used when the exact number of iterations is known beforehand.
   How It Works: Initializes a counter variable, checks a specific condition, executes the internal statement, and automatically updates the counter after each cycle until the condition evaluates to false.

3. While Loop (Infinite Loop Exception)
 Concept: Demonstrates a common logical bug caused by missing state modification.
 How It Works: If the condition evaluation variable is never incremented or updated, the condition remains permanently true, causing the loop to run indefinitely and freezing the application.

4. Do-While Loop
 Concept: Guarantees that the code block will execute at least once, regardless of whether the condition is initial true or false.
 How It Works: Performs the statement first and tests the evaluation condition at the end of the first pass, controlling subsequent iterations based on the result.

