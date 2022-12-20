// See https://aka.ms/new-console-template for more information
// Open Source Caculator made by codingislikelearninganewlanguage
// If you have any questions email me at kingkong2019.com@gmail.com
Console.WriteLine("First number please");
var firstnum = Console.ReadLine();
Console.WriteLine("Second number please");
var secondnum = Console.ReadLine();
Console.WriteLine("Method 1:Addition 2:Subtraction 3:Multiplication");
var method = Console.ReadLine();
var firstnumparsed = int.Parse(firstnum);
var secondnumparsed = int.Parse(secondnum);
if (method == "1") 
{
    Console.WriteLine(firstnumparsed + secondnumparsed);
}
if(method == "2")
{
    Console.WriteLine(firstnumparsed - secondnumparsed);
}
if (method == "3")
{
    Console.WriteLine(firstnumparsed * secondnumparsed);
}
