namespace PaintBrush;
using DrawShapes;
using System.Drawing;
// using Graphics;
public partial class Form1 : Form
{
    DrawShapes.Point StartPoint;
    DrawShapes.Point EndPoint;
    
    public Form1()
    {
        MouseDown += new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+= new System.Windows.Forms.MouseEventHandler(onMouseUp);
        InitializeComponent();
    }

    public void onMouseDown(object sender,MouseEventArgs e){
        StartPoint=new DrawShapes.Point(e.X,e.Y);
    }
    public void onMouseUp(object sender,MouseEventArgs e){
        EndPoint=new DrawShapes.Point(e.X,e.Y);
        Line l=new Line(StartPoint,EndPoint,"red",3);
        Pen pen=new Pen(Color.FromArgb(255,255,0,0));
        Graphics g=this.CreateGraphics();
        // Console.WriteLine(l.StartPoint.X);
        g.DrawLine(pen,l.StartPoint.X,l.StartPoint.Y,l.EndPoint.X,l.EndPoint.Y);
        // g.DrawLine(pen,10,20,50,60);
    }

}
