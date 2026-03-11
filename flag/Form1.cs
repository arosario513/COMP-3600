namespace flag;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void DrawBase(Graphics g)
    {
        g.FillRectangle(Brushes.Red, 50, 50, 500, 300);
        g.FillRectangle(Brushes.White, 50, 110, 500, 60);
        g.FillRectangle(Brushes.White, 50, 230, 500, 60);
    }
    private void DrawTriangle(Graphics g)
    {
        SolidBrush lbBrush = new(ColorTranslator.FromHtml("#60d0ff"));
        Point[] points = {
            new Point(50,50),
            new Point(300,200),
            new Point(50,350),

        };
        g.FillPolygon(lbBrush, points);
    }
    private void DrawStar(Graphics g)
    {
        Point[] starPoints = {
            new Point(145, 155),
            new Point(160, 185),
            new Point(195, 185),
            new Point(165, 205),
            new Point(175, 235),
            new Point(145, 215),
            new Point(115, 235),
            new Point(125, 205),
            new Point(95, 185),
            new Point(130, 185)
        };
        g.FillPolygon(Brushes.White, starPoints);
    }
    private void DrawFlag(Graphics g)
    {
        DrawBase(g);
        DrawTriangle(g);
        DrawStar(g);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawFlag(e.Graphics);

    }
}
