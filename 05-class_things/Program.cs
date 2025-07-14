Person person1 = new Person();

Console.WriteLine("What is your name? ");
person1.name = Console.ReadLine()!;

Person person2 = new Person();

Console.WriteLine("What is your name? ");
person2.name = Console.ReadLine()!;

person1.level_up();

for (int i = 1; i <= 10; i++)
{
    person1.attack(person2);
}