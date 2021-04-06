﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphRedaktor.Models.Figures
{
    public class FigureLine : SimpleFigure
    {
        public override void DrawFigure(Graphics graphics, Pen myPen, int coordX, int coordY, int width, int height)
        {
            if (graphics == null)
                return;
            if (myPen == null)
                return;

            graphics.DrawLine(myPen, coordX, coordY, width, height);
        }
        public override void Draw(Color figureColor, Bitmap tempDraw, PaintEventArgs pea)
        {
            Graphics g = Graphics.FromImage(tempDraw);
            Pen myPen = new Pen(figureColor, Constants.PenSize);

            DrawFigure(g, myPen, BeginPoint.X, BeginPoint.Y, EndPoint.X, EndPoint.Y);
            myPen.Dispose();
            pea.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            g.Dispose();
        }
        public override string ToString()
        {
            return "прямая линия";
        }
    }
}
