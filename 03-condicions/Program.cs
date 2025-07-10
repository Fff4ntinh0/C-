Console.WriteLine("What is your name ?");
string name = Console.ReadLine()!;

Console.WriteLine("Have you a vote pass ? [yes] or [not]");
string vote = Console.ReadLine()!;

Console.WriteLine("How older are you ?");
int age = Convert.ToInt32(Console.ReadLine());

bool cond1 = age < 18;
bool cond2 = age >= 18 && age < 60;
bool cond3 = age >= 60;
bool cond4 = vote == "yes";

if (cond1)
{
    Console.WriteLine($"Hello {name}, with {age} years you must not vote and cannot drink alcoolic drinks");
}
else if (cond2 && cond4)
{
    Console.WriteLine($"Hello {name}, with {age} years, you must vote and can drink alcoolic drinks");
}
else if (cond3 && cond4)
{
    Console.WriteLine($"Hello {name}, with {age} years, you can vote and can drink alcoolic drinks");
}
else
{
    Console.WriteLine("You cannot vote");
}
