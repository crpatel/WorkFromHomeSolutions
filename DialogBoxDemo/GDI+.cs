using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBoxDemo
{
    public partial class GDI_ : Form
    {
        public GDI_()
        {
            InitializeComponent();
            this.Paint += GDI__Paint;
        }

        private void GDI__Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.White), 0, 0, 100, 200);
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(100, 100, 200, 299));
            e.Graphics.FillEllipse(Brushes.AliceBlue, 100, 100, 200, 299);
        }

        private void btnRactangle_Click(object sender, EventArgs e)
        {

        }

        private void GDI__Load(object sender, EventArgs e)
        {

        }
    }
}
