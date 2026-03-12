namespace emoji2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }
    private void DrawCircle(int x, int y, int size, Graphics g)
    {
        g.FillEllipse(Brushes.Yellow, x, y, size, size);
        g.DrawEllipse(Pens.Black, x, y, size, size);
    }
    private void DrawEye(int x, int y, int size, Graphics g)
    {
        g.FillPie(Brushes.BurlyWood, x, y + 25, size, size, 0, 180);
        g.FillPie(Brushes.White, x, y, size, size, 0, 180);
        g.FillPie(Brushes.Black, x + 50, y + 50, size / 2, size / 2, 0, 180);
        g.DrawPie(Pens.Black, x, y, size, size, 0, 180);
    }

    private void DrawEyebrow(int x, int y, Graphics g)
    {
        g.FillRectangle(Brushes.Black, x, y, 200, 25);
    }
    private void DrawMouth(int x, int y, Graphics g)
    {
        g.DrawArc(Pens.Black, x, y, 200, 200, 0, -180);
    }
    private void DrawEmoji(Graphics g)
    {

        DrawCircle(20, 20, 500, g);
        DrawEye(60, 50, 200, g);
        DrawEye(280, 50, 200, g);
        DrawEyebrow(60, 100, g);
        DrawEyebrow(280, 100, g);
        DrawMouth(170, 300, g);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawEmoji(e.Graphics);
    }
}
