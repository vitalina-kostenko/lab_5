using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

public class Rhomb : Figure
{
    private int horDiagLen;
    private int vertDiagLen;

    public Rhomb(int x, int y, int horDiagLen, int vertDiagLen) : base(x, y)
    {
        this.horDiagLen = horDiagLen;
        this.vertDiagLen = vertDiagLen;
    }

    private Point[] GetVertices()
    {
        return new Point[]
        {
                new Point(centerX, centerY - vertDiagLen / 2),
                new Point(centerX + horDiagLen / 2, centerY),
                new Point(centerX, centerY + vertDiagLen / 2),
                new Point(centerX - horDiagLen / 2, centerY)
        };
    }

    public override void DrawBlack()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawPolygon(Pens.Black, GetVertices());
    }

    public override void HideDrawingBackGround()
    {
        Graphics graphics = Form1.ActiveForm.CreateGraphics();
        graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetVertices());
    }
}