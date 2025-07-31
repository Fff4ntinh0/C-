using System;

public class Person
{
    public string Name
    {
        get;
        set
        {
            if (value.Length >= 3)
            {
                field = value;
            }
            else
            {
                Console.WriteLine("Name must be at least 3 characters long.");
            }
        }
    }

    private int strength;
    public int Strength
    {
        get;
        set => field = value;
    }

    private int life;
    public int Life
    {
        get => life;
        set => life = value;
    }

    private int intelligence;
    public int Intelligence
    {
        get => intelligence;
        set => intelligence = value;
    }

    private int level;
    public int Level
    {
        get => level;
        set => level = value;
    }

    public Person()
    {
        strength = 10;
        life = 100;
        intelligence = 20;
        level = 1;
    }

    public void LevelUp()
    {
        level += 1;
        strength += (level * 2);
        intelligence += (level * 2);
        life += (level * 2);

        Console.WriteLine($"[Level Up] {Name} => Strength = {strength}, Life = {life}, Intelligence = {intelligence}");
    }

    public void Attack(Person other)
    {
        other.life -= strength;
        Console.WriteLine($"{Name} attacked {other.Name}! {other.Name}'s life is now {other.life}");

        if (other.life <= 0)
        {
            Console.WriteLine($"{other.Name} has died.");
        }
    }
}
