using SimpleFileExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssigmentWeek3
{
    public partial class displayImg : Form
    {
        public displayImg()
        {
            InitializeComponent();
        }
        public displayImg(string strTextBox)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@strTextBox);
            this.Text= strTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
