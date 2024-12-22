// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Linq.Expressions;
ArrayList Fruits = new ArrayList()
{
    "apple", "cherry", "banana"
};
foreach (var f in Fruits)
{
    Console.WriteLine(f);
}
Fruits.Insert(2, "Orange");
Fruits.Remove(0);
Console.WriteLine("New list");
foreach (var f in Fruits)
{
    Console.WriteLine(f);
}
Console.WriteLine("type any fruit:");
string check = Console.ReadLine().ToLower();
if (Fruits.Contains(check))
{
    Console.WriteLine("it exists at " + Fruits.IndexOf(check));
}
else Console.WriteLine("it doesn't");
    Console.WriteLine("The number of elements is: ");
    Console.WriteLine(Fruits.Count);

