using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

public class сircle : Figure
{
    private int radius;

    public сircle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public override void DrawBlack()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
    }

    public override void HideDrawingBackGround()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), centerX - radius, centerY - radius, 2 * radius, 2 * radius);
    }
}
