namespace DrawShapes;

public abstract class shape{
    public string Color{
        get;set;
    }

    public int Width{
        get;
        set;
    }

    public shape()
    {
        Color="red";
        Width=0;
    }

    public shape(string a,int b)
    {
        Color=a;
        Width=b;
    }
    public abstract void Draw();

    public override string ToString()
    {
        return "color "+ Color+" width "+Width;
    }

}