// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//LOOOOPS 

//Write a for loop that prints all numbers from 1 to 50 (50 inclusive).
for(int i=1; i<=50; i++)
{
    Console.WriteLine(i);
}

//Write a for loop that prints all even numbers between 1 and 50 (50 exclusive, which means the last number we should see is 48).
for(int i=1; i<50; i++)
if(i%2 ==0)
{
    Console.WriteLine(i);
}
//There are a couple of ways you can do this! Try to figure them both out:
//First by modifying the iterator
for(int i=2; i<50; i+=2)
{
    Console.WriteLine(i);
}
//Second by adding a conditional statement in the loop


//In your first loop that goes from 1 to 50, add a condition that prints "+10" for every 10 iterations (you should see +10 in the terminal 5 times) -- you may need to think about how to do this one for a bit!
for(int i=1; i<=50; i++)
if(i%10==0)
{
    Console.WriteLine($"{i} +10");
}
//Write a loop that decrements by threes from 99 to 0 and prints the values (all numbers you see should be divisible by 3 if you do this right)
for(int i=99; i>0; i-=3)
{
    Console.WriteLine(i);
}
