using System.Globalization;

double grade_every = 0;
int i = 1;

while (i!= 10)
{
    Console.WriteLine("What is his/her name ? ");
    string name = Console.ReadLine()!;

    Console.WriteLine("What is his/her grade ? ");
    double grade = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Student {name} : {grade}");
    grade_every = grade_every + grade;
    i += 1;

}
double result = grade_every /= 10;
Console.WriteLine(result);