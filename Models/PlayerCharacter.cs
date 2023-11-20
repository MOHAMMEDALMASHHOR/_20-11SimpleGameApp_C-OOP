public class PlayerCharacter : AbstractCharacter, ISkills
{
    public PlayerCharacter(string name, int power, double mana, int defence, double health) : base(name, power, mana, defence, health)
    {
    }

    public void Fireball(AbstractCharacter traget)
    {
        if (Mana>0)
        {
            traget.Hit(25);
            Mana-=20;
        }
        else
        {
            System.Console.WriteLine("Fireball can't be used!!");
        }
    }

    public void Heal(AbstractCharacter character)
    {
        if (Mana>0)
        {
            Health+=20;
            Mana-=10;
        }
        else
        {
            System.Console.WriteLine("Healing can't be used!!!");
        }
    }
}