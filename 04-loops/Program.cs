Console.WriteLine("Choose a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Until what number? ");
int num2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= num2; i++)
{
    Console.WriteLine($"{num1} x {i} = {num1*i}");
}

