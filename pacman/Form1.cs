namespace pacman;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Pacman
        e.Graphics.FillPie(Brushes.Yellow,100,100,250,250,45,270);

        // Ms. Pacman
        e.Graphics.FillPie(Brushes.Yellow,500,100,250,250,225,270);
        e.Graphics.FillPie(Brushes.Red,500,100,250,250,220,5);
        e.Graphics.FillPie(Brushes.Red,500,100,250,250,130,5);
        e.Graphics.FillEllipse(Brushes.Black,625,150,25,25);

        // Dots
        e.Graphics.FillEllipse(Brushes.White,300,200,50,50);
        e.Graphics.FillEllipse(Brushes.White,400,200,50,50);
        e.Graphics.FillEllipse(Brushes.White,500,200,50,50);
    }
}
