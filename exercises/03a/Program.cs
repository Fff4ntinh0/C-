Console.WriteLine("How much do you weigh ? ");
float weigh = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("How tall are you ? ");
float height = Convert.ToSingle(Console.ReadLine());

double height_pow = Math.Pow(height, 2);
double cond1 = weigh / height_pow;

switch (cond1)
{
    case < 18.5:
        Console.WriteLine("Underweight");
        Console.WriteLine(cond1);
        break;
    case >= 18.5 and <= 24.9:
        Console.WriteLine("Normal weight");
        Console.WriteLine(cond1);
        break;
    case >= 25 and <= 29.9:
        Console.WriteLine("Overweight");
        Console.WriteLine(cond1);
        break;
    case >= 30 and <= 34.9:
        Console.WriteLine("Obesity I");
        Console.WriteLine(cond1);
        break;
    case >= 35 and <= 39.9:
        Console.WriteLine("Obesity II");
        Console.WriteLine(cond1);
        break;
    case >= 40 and <= 49.9:
        Console.WriteLine("Obesity III");
        Console.WriteLine(cond1);
        break;
    case >= 50 and <= 59.9:
        Console.WriteLine("Obesity IV");
        Console.WriteLine(cond1);
        break;
    case >= 60:
        Console.WriteLine("Obesity V");
        Console.WriteLine(cond1);
        break;
    default:
        break;
}