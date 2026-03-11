namespace inter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillEllipse(Brushes.Yellow, 100, 50, 100, 100);
        e.Graphics.FillRectangle(Brushes.Green, 100, 175, 100, 200);
    }
}
