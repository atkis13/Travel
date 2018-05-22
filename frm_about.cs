using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
            pictureBox1.Image = Resource1._5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
