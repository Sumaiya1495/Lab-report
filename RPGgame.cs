using System;


class Player
{
	public string Name;
	public int Health;
	public int Energy;
	public int XP;

	public Player(string name, int health, int energy)
	{
		Name = name;
		Health = health;
		Energy = energy;
		XP = 0;
	}

	public virtual void Attack(Player target)
	{
		Console.WriteLine($"{Name} attacks!");
		target.TakeDamage(10);
	}

	public void TakeDamage(int damage)
	{
		Health -= damage;
		if (Health < 0) Health = 0;
		Console.WriteLine($"{Name} takes {damage} damage. Health: {Health}");
	}

	public virtual void Dodge ()
	{

	}

	public bool IsAlive()
	{
		return Health > 0;
	}
}

class Warrior : Player
{
	public Warrior(string name) : base(name, 120, 50) { }

	public override void Attack(Player target)
	{
		if (Energy >= 10)
		{
			Console.WriteLine($"{Name} swings their sword!");
			target.TakeDamage(40);
			Energy -= 10;
		}
		else
		{
			Console.WriteLine($"{Name} is out of energy!");
		}
	}

	public override void Dodge ()
	{
		Console.WriteLine("You dodged the enemy!");
	}
}

class Mage : Player
{
	public Mage(string name) : base(name, 100, 60) { }

	public override void Attack(Player target)
	{
		if (Energy >= 15)
		{
			Console.WriteLine($"{Name} casts a fireball!");
			target.TakeDamage(50);
			Energy -= 15;
		}
		else
		{
			Console.WriteLine($"{Name} is out of energy!");
		}
	}

	public override void Dodge ()
	{
		Console.WriteLine("You dodged the enemy!");
	}
}

class Boss : Player
{
	public Boss(string name) : base(name, 200, 40) { }

	public override void Attack(Player target)
	{
		Console.WriteLine($"{Name} unleashes a powerful attack!");
		target.TakeDamage(25);
	}
}

static class NPC
{

	public static void Quest ()
	{
		Console.WriteLine("A strange villager offers you to retrive an ancient relic!");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Choose your character: 1. Warrior  2. Mage");
		int choice = int.Parse(Console.ReadLine());

		Player player;
		if (choice == 1)
		{
			player = new Warrior("Hero");
		}
		else
		{
			player = new Mage("Hero");
		}

		NPC.Quest();
		Console.WriteLine("To accept the quest press 1");
		int action1 = int.Parse(Console.ReadLine());

		if (action1 == 1)
		{
			Console.WriteLine("You have successfully retrived the relic, your XP is increased!");
			player.XP += 50;
		}


		Player boss = new Boss("Dragon");

		Console.WriteLine($"You are {player.Name}, and you encounter the {boss.Name}!");

		while (player.IsAlive() && boss.IsAlive())
		{
			Console.WriteLine("What do you want to do? 1. Attack  2. Dodge");
			int action = int.Parse(Console.ReadLine());

			if (action == 1)
			{
				player.Attack(boss);
			}
			else if (action == 2)
			{
				player.Dodge();
			}
			else
			{
				boss.Attack(player);
			}


		}

		if (player.IsAlive())
		{
			Console.WriteLine("You defeated the boss! Congratulations!");
		}
		else
		{
			Console.WriteLine("You were defeated by the boss... Game Over.");
		}
	}
}
