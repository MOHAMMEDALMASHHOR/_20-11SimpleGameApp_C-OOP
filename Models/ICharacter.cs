public interface ICharacter{
    public string Name { get; set; }
    public double Health { get; set; }
    public int Power { get; set; }
    public int Defence { get; set; }
    public void Attach(AbstractCharacter target);
    public void Hit( int damage);
    /* public void Method(){
        you can now imlement a body for the interface. But if you want to use it you have to rewrite it again in the inhertanted class!!!
    } */
}