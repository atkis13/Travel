using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Travel
{
    public partial class frm_add_dest : Form
    {
        string filePath;
        public frm_add_dest()
        {
            InitializeComponent();
            pictureBox1.Image = Resource1._4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mainID = Form_Methods.GenerateID(txt_dest.Text, date_start);
            filePath = Application.StartupPath + @"\\images\" + mainID;
            Directory.CreateDirectory(filePath);
            Form_Methods.AddID(mainID);
            Form_Methods.AddDestination(mainID, txt_dest.Text, date_start.Text, date_end.Text, txt_start_loc.Text, txt_no_person.Text, txt_note.Text, Int32.Parse(txt_spending.Text));
            Form_Methods.AddSpending(mainID, Int32.Parse(txt_spending.Text), "spending");
        }
    }
}
