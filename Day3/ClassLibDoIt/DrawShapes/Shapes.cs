namespace DrawShapes;

public class shape{
    public string Color{
        get;set;
    }

    public int width{
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
    public abstract class Draw();

    public override string ToString()
    {
        return "color "+ Color+" width "+width;
    }

}