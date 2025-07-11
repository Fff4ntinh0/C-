Console.WriteLine("What is the value?  ");
int prec = Convert.ToInt32(Console.ReadLine());

for (double i = 2; i <= 12; i++)
{
    double parc = prec / i;
    Console.WriteLine($"A parcela de x{i} da compra de valor {prec} é {parc.ToString("F2")}");
}