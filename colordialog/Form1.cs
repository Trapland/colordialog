using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colordialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            this.BackColor = c;
        }
    }
}
