namespace ghosts;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void DrawEye(int x, int y, int size, Graphics g)
    {
        g.FillEllipse(Brushes.White, x, y, size, size);
        g.FillEllipse(Brushes.Black, x + (size / 4) - 10, y + (size / 4), size / 2, size / 2);
        g.DrawEllipse(Pens.Black, x, y, size, size);
    }
    private void DrawGhost(int x, int y, Brush color, Graphics g)
    {
        g.FillEllipse(color, x, y, 200, 200);

        Point[] body =
        [
            new(x,       y + 120),
            new(x,       y + 240),
            new(x + 33,  y + 190),
            new(x + 67,  y + 240),
            new(x + 100, y + 190),
            new(x + 133, y + 240),
            new(x + 167, y + 190),
            new(x + 200, y + 240),
            new(x + 200, y + 120),
        ];
        g.FillPolygon(color, body);


        DrawEye(x + 20, y + 55, 50, g);
        DrawEye(x + 110, y + 55, 50, g);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawGhost(20, 20, Brushes.Red, e.Graphics);
        DrawGhost(500, 20, Brushes.Blue, e.Graphics);
        DrawGhost(250, 20, Brushes.Orange, e.Graphics);

    }
}
