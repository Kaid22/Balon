using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Balon[] b = new Balon[20];
        int n = 20;
        Random r = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <n; i++)
            {
                int a = r.Next(10, 15);
                int x = r.Next(40, ClientRectangle.Width);
                int y = r.Next(10, ClientRectangle.Height);
                Color boja = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                b[i] = new Balon(x, y, a, boja);
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Point t = new Point(e.X, e.Y);
            for (int i = 0; i < n; i++) 
{
                if (b[i].Sadrzi(t))
                {
                    b[i].PostaviBoju(Color.Transparent);
                }
            }
            Refresh();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
{
                b[i].Crtaj(e.Graphics);
            }
        }
    }
}
