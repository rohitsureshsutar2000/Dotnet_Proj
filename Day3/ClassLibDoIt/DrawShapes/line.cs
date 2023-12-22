namespace DrawShapes;

public class Line:shape{

    public Point StartPoint{
        get;set;
    }
 
    public Point EndPoint{
        get;set;
    }
    public Line():base()
    {
        StartPoint=new Point(0,0);
        EndPoint=new Point(0,0);
    }
    public Line(Point sp,Point se,string c,int w):base(c,w)
    {
        StartPoint=new Point(0,0);
        EndPoint=new Point(0,0);
    }
    public override void Draw()
    {
        Console.WriteLine("hello can we draw shapes");
    }

    
    public override string ToString()
    {
        return base.ToString()+this.StartPoint+" "+this.EndPoint;
    }
}