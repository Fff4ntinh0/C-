using System.Collections.Specialized;
using System.IO.Compression;

public class Person
{
    public string name;
    public int strenge;
    public int life;
    public int intelligence;
    public int level;

    public Person()
    {
        strenge = 10;
        life = 100;
        intelligence = 20;
        level = 1;
    }

    public void level_up()
    {
        level += 1;
        strenge += (level * 2);
        intelligence += (level * 2);
        life += (level * 2);

        Console.WriteLine($"Strenger = {strenge}, Life = {life}, Intelligence = {intelligence} by {name}");
    }

    public void attack(Person other)
    {

        other.life -= strenge;
        Console.WriteLine($"{name} attacked {other.name} and {other.name}'life now is: {other.life}");

        if (other.life <= 0)
        {
            Console.WriteLine($"{other.name} is died");
        }

    }



}
