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
    public partial class frm_complete : Form
    {
        public frm_complete()
        {
            InitializeComponent();
            pictureBox1.Image = Resource1._3;
            Form_Methods.GetIDs(cmb_id);
        }

        private void btn_done_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
