using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using WindowsFormsApplication1;

public class Form1 : Form
{
    public Form1()
    {
        this.Text = "Figures";
        this.Size = new Size(800, 600);
        this.BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        сircle circle = new сircle(200, 300, 50);
        Square square = new Square(400, 300, 100);
        Rhomb rhomb = new Rhomb(600, 300, 120, 80);

        circle.MoveRight();
        square.MoveRight();
        rhomb.MoveRight();
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new Form1());
    }
}