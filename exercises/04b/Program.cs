Console.WriteLine("What is your number? ");
int num1 = Convert.ToInt32(Console.ReadLine());

for (int g = num1; g <= num1 && g >=0; g--)
{
    int result = num1 - g;
    Console.WriteLine(result);
}
