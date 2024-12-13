using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        public Figure(int x, int y)
        {
            centerX = x;
            centerY = y;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
