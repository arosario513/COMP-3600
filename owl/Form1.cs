namespace owl;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void DrawSquare(int x, int y, int size, Graphics g)
    {
        g.FillRectangle(Brushes.Blue, x, y, size, size);
        g.DrawRectangle(Pens.Black, x, y, size, size);
    }
    private void DrawEye(int x, int y, int size, Graphics g)
    {
        g.FillEllipse(Brushes.White, x, y, size, size);
        g.DrawEllipse(Pens.Black, x, y, size, size);
        g.FillEllipse(Brushes.Black, x + size / 4, y + size / 4, size / 2, size / 2);
    }
    private void DrawBody(int x, int y, Graphics g)
    {
        SolidBrush CustomBrush = new(ColorTranslator.FromHtml("#7070ff"));
        g.FillPie(CustomBrush, x, y, 250, 250, 0, -180);
    }
    private void DrawBeak(int x, int y, Graphics g)
    {
        Point[] points = {
            new Point(0+x,0+y),
            new Point(50+x,0+y),
            new Point(25+x,50+y),
        };
        g.FillPolygon(Brushes.Yellow, points);
        g.DrawPolygon(Pens.Black, points);
    }
    private void DrawFoot(int x, int y, Graphics g)
    {
        g.FillRectangle(Brushes.SandyBrown, x, y, 75, 25);

        for (int i = 0; i < 4; i++)
        {
            g.DrawRectangle(Pens.Black, x, y, (75 / 3) * i, 25);
        }

    }
    private void DrawBranch(int x, int y, Graphics g)
    {
        g.FillRectangle(Brushes.SaddleBrown, x, y, 500, 25);
        g.DrawRectangle(Pens.Black, x, y, 500, 25);
    }
    private void DrawMoon(int x, int y, int size, Graphics g)
    {
        SolidBrush CustomBrush = new(ColorTranslator.FromHtml("#100030"));
        g.FillEllipse(Brushes.Beige, x, y, size, size);
        g.FillEllipse(CustomBrush, x + 30, y, size - 10, size - 10);
    }
    private void DrawOwl(Graphics g)
    {
        DrawSquare(20, 20, 250, g);
        DrawEye(30, 30, 100, g);
        DrawEye(160, 30, 100, g);
        DrawBody(20, 145, g);
        DrawBeak(120, 120, g);
        DrawFoot(30, 255, g);
        DrawFoot(185, 255, g);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBranch(0, 270, e.Graphics);
        DrawOwl(e.Graphics);
        DrawMoon(350, 20, 100, e.Graphics);
    }
}
