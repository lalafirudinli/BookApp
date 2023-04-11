
internal class BMW : Car
{
    private bool isPower = true;

    public bool Ispower
    {
        get
        {
            return isPower;
        }
        set
        {
            isPower = value;
        }
    }

    public BMW(string model, int topspeed, double engine, double km, int hp) : base(model, topspeed, engine, km, hp)
    {
    }


}

