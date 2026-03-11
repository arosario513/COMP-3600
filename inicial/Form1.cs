namespace inicial;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    protected override void OnPaint(PaintEventArgs e) {
        e.Graphics.DrawLine(Pens.Black,100,20,50,100);
        e.Graphics.DrawLine(Pens.Black,100,20,150,100);
        e.Graphics.DrawLine(Pens.Black,50,50,150,50);
    }
}
