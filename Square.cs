using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Square : UserControl
    {
        Main parent;
        public Square(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
ControlStyles.UserPaint |
ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //btn.Visible = false;
        }

        public Label getLbl
        {
            get { return label1; }
        }

        public string setLbl
        {
            set { label1.Text = value; }
        }

        public Button getBtn 
        {
            get { return btn; }

        }
    

    }
}
