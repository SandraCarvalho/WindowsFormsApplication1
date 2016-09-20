using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void DrawLabeledRect(Graphics g, string label)
        {  // Always draw at (0, 0) and let the client  
           // set the position using a transform  
            RectangleF rect = new RectangleF(0, 0, 125, 125);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
            g.DrawString(label, this.Font, Brushes.Black, rect, format);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void queToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }

}


