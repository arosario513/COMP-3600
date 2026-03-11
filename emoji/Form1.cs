namespace emoji;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.FillEllipse(Brushes.Yellow, 50, 100, 500, 500);
        e.Graphics.DrawEllipse(Pens.Black, 50, 100, 500, 500);
        e.Graphics.FillEllipse(Brushes.Blue,150, 250, 100, 100);
        e.Graphics.FillEllipse(Brushes.Blue, 350, 250, 100, 100);
        e.Graphics.FillEllipse(Brushes.Red, 200, 400, 200, 100);
    }
}
