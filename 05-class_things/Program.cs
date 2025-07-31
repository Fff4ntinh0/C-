Person person1 = new Person();
Console.Write("What is the name of the first character? ");
person1.Name = Console.ReadLine()!;

Person person2 = new Person();
Console.Write("What is the name of the second character? ");
person2.Name = Console.ReadLine()!;

person1.LevelUp();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\n[Round {i}]");
    person1.Attack(person2);
    if (person2.Life <= 0)
        break;
}
