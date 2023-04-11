
public class Mercedes : Car
{
    private bool isamg = true;

    public bool İsAmg
    {
        get
        {
            return isamg;
        }
        set {
            isamg = value;
        }
    }

    public Mercedes(string model, int topspeed, double engine, double km, int hp) : base(model, topspeed, engine, km, hp)
    {
    }

}

