using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

public class Square : Figure
{
    private int sideLength;

    public Square(int x, int y, int sideLength) : base(x, y)
    {
        this.sideLength = sideLength;
    }

    public override void DrawBlack()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawRectangle(Pens.Black, centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
    }

    public override void HideDrawingBackGround()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawRectangle(new Pen(Form1.ActiveForm.BackColor), centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
    }
}