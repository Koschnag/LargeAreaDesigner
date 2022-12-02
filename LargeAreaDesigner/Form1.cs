using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeAreaDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navigation_Click(object sender, EventArgs e)
        {
            int tabIndex = 0;

            if (sender is Button button)
            {
                string tag = button.Tag as string;
                tabIndex = int.Parse(tag);
            }

            tabControl1.SelectTab(tabIndex);
        }

        private void abschicken_Click(object sender, EventArgs e)
        {

        }
    }
}
