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
    public partial class frm_est_expense : Form
    {
        public frm_est_expense()
        {
            InitializeComponent();
            Form_Methods.GetIDs(cmb_id);
        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_est_Click(object sender, EventArgs e)
        {
            lbl_est.Text =  Form_Methods.getEstExpense(cmb_id.Text).ToString();

        }

        private void btn_add_est_Click(object sender, EventArgs e)
        {
            Form_Methods.AddSpending(cmb_id.Text, Int32.Parse(lbl_est.Text), "total_est");
        }
    }
}
