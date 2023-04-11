
public class Car
{
    private string model;
    private int topspeed;
    private double engine;
    private double km;
    private int hp;

    public string Model
    {
        get
        {
            return model;
        }
        set
        { if (model.Length < 1 || model.Length > 10)
            {
                Console.WriteLine(" Model is invalid ");
            }
            else
            {
                model = value;
            }
        }
    }
    public int Topspeed
    {
        get
        {
            return topspeed;
        }
        set
        {
            if (topspeed < 10 || topspeed > 1000)
            {
                Console.WriteLine(" Topspeed is invalid  ");
            }
            else
            {
                topspeed = value;
            }
        }
    }
    public double Engine
    {
        get
        {
            return engine;
        }
        set
        {
            if (engine<0.3 || engine > 10)
            {
                Console.WriteLine(" Engine is invalid  ");
            }
            else
            {
                engine = value;
            }
        }
    }
    public double Km
    {
        get
        {
            return km;
        }
        set
        {
            if (km <= 0)
            {
                Console.WriteLine("Km is invalid  ");
            }
            else
            {
                km = value;
            }
        }
    }
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (hp < 50 || hp > 1000)
            {
                Console.WriteLine("Hp is invalid  ");
            }
            else
            {
                hp = value;
            }
        }
    }

   
    public Car(string model, int topspeed, double engine, double km, int hp)
    {   this.model = model;
        this.topspeed = topspeed;
        this.engine = engine;
        this.km = km;
        this.hp = hp;
    }

    public Car() {

    }
    public void GetFullInfo()
    {
        Console.WriteLine(this.model + "" + this.topspeed + "" + this.engine + "" + this.km + "" + this.hp);
    }
}

