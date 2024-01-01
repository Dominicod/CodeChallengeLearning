using LearningConsole;

var solution = new MaximumSubarraySumClass();

Console.WriteLine("Input: ([ 1,5,4,2,9,9,9 ], 3)");
Console.WriteLine("Expected Output: 15");
Console.WriteLine("Result: " + solution.MaximumSubarraySum(new[] { 1,5,4,2,9,9,9 }, 5));

Console.WriteLine("Input: ([4,4,4], 3)");
Console.WriteLine("Expected Output: 0");
Console.WriteLine("Result: " + solution.MaximumSubarraySum(new[] { 4,4,4 }, 3));

Console.WriteLine("Input: ([4,4,4], 1)");
Console.WriteLine("Expected Output: 0");
Console.WriteLine("Result: " + solution.MaximumSubarraySum(new[] { 4,4,4 }, 1));