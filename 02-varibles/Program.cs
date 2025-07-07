using System.Reflection.Metadata;

int n1 = 3;
string s1 = "Hello World";
float f1 = 1.234F;
double d1 = -1.25849020393484;
char c1 = '!';
bool b1 = true;
string name = "Fffantinho";

double r = n1 + f1 - d1 * (d1 / n1);

Console.WriteLine($"The result is: {r}");
Console.WriteLine(s1 + c1);
Console.WriteLine(b1);

string w = $"""
    Welcome {name}, 
    nice to meet you
    """;

string z = $"""O texto "{w}" tem {w.Length} caracteres""";

Console.WriteLine(z);

Console.WriteLine("What is your favorite game? ");
string text1 = Console.ReadLine();

Console.WriteLine($"How much is the {text1}? ");
double prec1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Your game is {text1} and the price is {prec1:F2} dollars");
