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
            try
            {
                Form_Methods.GetIDs(cmb_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_est_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_est.Text = Form_Methods.getEstExpense(cmb_id.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbl_est.Visible = true;

        }

        private void btn_add_est_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.AddSpending(cmb_id.Text, Int32.Parse(lbl_est.Text), "total_est");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Estimations Added");
        }

    }  

}
