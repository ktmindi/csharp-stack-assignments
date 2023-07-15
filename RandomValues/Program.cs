// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random rand = new Random();

for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,8));
}

// How would you modify the example code above to include 8?
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,9));
}

// Try all the different versions of .Next listed in the chart.
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next());
}
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(10));
}
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.NextDouble());
}
// See what sorts of numbers each one is producing and how you might be able to use those values. Leave comments in your code on your results.

// Which one of the methods you tested would be ideal for creating a dice roller?
// Combine what you've learned so far! Write a loop that runs 15 times and gets a random number between 1 and 10 (10 inclusive) each time. However, you should only print the value if it is equal to 1 OR 7. Run this code several times and see how many times you get results on each run. Tip: Break this problem into multiple parts, first get ALL values to print, then limit it to only printing the values you need.