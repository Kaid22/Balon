using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balon
{
    using System.Drawing;
    class Balon
    {
        #region atributi
        private int x, y, a;
        private Color boja;
        #endregion
        #region konstruktor
        public Balon(int x, int y, int a, Color boja)

        {
            if (a <= 0)
throw new Exception( "Velicina mora biti veca od nule");
            this.x = x;
            this.y = y;
            this.a = a;
            this.boja = boja;
        }
        #endregion
        #region metode
        public void PostaviBoju(Color boja)
        {
            this.boja = boja;
        }
        public Color VratiBoju()
        {
            return boja;
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 5);
            SolidBrush cetka = new SolidBrush(boja);
            g.FillEllipse(cetka, x - 3 * a, y - 8 * a, 6 * a, 8 * a);
            Point t1 = new Point(x, y);
            Point t2 = new Point(x + a, y + a);
            Point t3 = new Point(x - a, y + a);
            Point[] trougao = { t1, t2, t3 };
            g.FillPolygon(cetka, trougao);
            g.DrawLine(olovka, x, y + a, x - a, y + 2 * a);
            g.DrawLine(olovka, x - a, y + 2 * a, x + a, y + 3 * a);
            g.DrawLine(olovka, x + a, y + 3 * a, x - a, y + 4 * a);
            g.DrawLine(olovka, x - a, y + 4 * a, x + a, y + 5 * a);
        }
        public bool Sadrzi(Point t)
        {
            int razX1 = t.X - (x - 3 * a);
            int razX2 = t.X - (x + 3 * a);
            int razY1 = t.Y - (y - 8 * a);
            int razY2 = t.Y - y;
            if ((razX1>0) && (razX2 < 0) && (razY1 > 0) && (razY2 < 0))
return true;
else
return false;
        }
        #endregion
    }
}
