Console.WriteLine("My programming languages: ");
Console.WriteLine(" - C++");
Console.WriteLine(" - C#");
Console.WriteLine(" - Python");
Console.WriteLine(" - Java");
Console.WriteLine(" - Javascript");


Console.WriteLine("Type a number");
double num = Convert.ToDouble(Console.ReadLine());

bool cond1 = (num % 2) == 0;

if (cond1)
{
    Console.WriteLine($"The number {num} is a even");
}
else
{
    Console.WriteLine($"The number {num} is a odd");
}