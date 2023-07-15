// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Write a conditional in which you will only allow customers greater than or equal to 42 inches and shorter than 78 inches to get on a roller coaster.
int inches = 92;
if(inches >= 42 && inches <78)
{
    Console.WriteLine("You are allowed on this roller coaster");
} else {
    Console.WriteLine("Sorry you are not allowed to ride this roller coaster");
}

//Write a conditional in which you check with a boolean whether an order has been completed. Print out "Order complete!" if so and "Order is still in process" if not.
bool order = true;
if(order = true)
{
    Console.WriteLine("Order complete!");
} else {
    Console.WriteLine("Order is still in process");
}

//Write a conditional in which you order your favorite drink (you pick the drink!). If you receive the wrong drink, print out "I ordered [insert your favorite drink here]."
string drink = "Green Machine";
string temperature = "hot";

if(drink != "Green Machine")
{
    Console.WriteLine($"I ordered {drink}");
} else if(drink == "Green Machine" && temperature == "cold"){
    Console.WriteLine("Thank you");
}else{
    Console.WriteLine("Send this Back Please");
}

//Bonus: Add to the above condition that if you receive the right drink but it is not in the right temperature range (hot or cold depending on your drink) then you send it back.