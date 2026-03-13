namespace bmw;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void DrawLogo(int x, int y, int size, Graphics g)
    {
        g.FillEllipse(Brushes.Black, x, y, size, size);
        g.FillEllipse(Brushes.White, x + 35, y + 35, size - 70, size - 70);
        g.FillPie(Brushes.LightSkyBlue, x + 35, y + 35, size - 70, size - 70, 180, 90);
        g.FillPie(Brushes.LightSkyBlue, x + 35, y + 35, size - 70, size - 70, 0, 90);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawLogo(20, 20, 300, e.Graphics);
    }
}
