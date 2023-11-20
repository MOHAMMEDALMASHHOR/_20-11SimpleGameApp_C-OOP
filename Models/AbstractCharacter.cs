public abstract class AbstractCharacter:ICharacter
{
    private double health;
    private double mana;


    public string Name { get ; set ; }
    public int Power { get ; set ; }
    public double Mana { get=>mana; set=>mana = HealthManaCheck(value); }
    public int Defence { get ; set ; }
    public double Health { get => health;
     set => health= HealthManaCheck(value); }
     
    public AbstractCharacter(string name, int power, int defence, double health)
    {
        Name = name;
        Power = power;
        
        Defence = defence;
        Health = health;
    }

    protected AbstractCharacter(string name, int power, double mana, int defence, double health):this(name,power,defence,health)
    {
        
        Mana = mana;
      
    }

    public void Attach(AbstractCharacter target)
    {
        var damage = Power-Defence;
        if (damage>0)
        {
            target.Hit(damage);
        }
        else
            System.Console.WriteLine($"{target.Name} blocked attack!");
    }

    public void Hit(int damage)
    {
        Health-=damage;
        if (Health<=0)
        {
            System.Console.WriteLine($"{Name} is defeated!");
        }
        else
        {
            System.Console.WriteLine($"{Name} took {damage} and still has {Health} left!!!");
        }

    }
    public double HealthManaCheck(double value){
        if (value >100){
            return 100;
        }
        else if (value<100)
        {
            return 0;
        }
        else
        {
            return value;
        }
    }
}