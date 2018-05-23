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
            try
            {
                Form_Methods.GetIDs(cmb_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            bool isComplete = false;
            try
            {
                isComplete = Form_Methods.isCompleted(cmb_id.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if (isComplete)
            {
                MessageBox.Show("Travel already completed");
            }
            else
            {
                int total = Int32.Parse(txt_housing.Text) + Int32.Parse(txt_trans_cost.Text) + Int32.Parse(txt_spending.Text);
                int balance = 0;
                if (ck_comp.Checked && cmb_id.Text != String.Empty && cmb_id.Text != null && cmb_id.Text != "")
                {
                    try
                    {
                        balance = Form_Methods.getTotalEstimate(cmb_id.Text) - total; ;
                        Form_Methods.CompleteTravel(cmb_id.Text);
                        Form_Methods.AddActualCost(cmb_id.Text, Int32.Parse(txt_housing.Text), Int32.Parse(txt_trans_cost.Text), Int32.Parse(txt_spending.Text), total, balance);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    MessageBox.Show("Travel Completed");
                    txt_housing.Text = "";
                    txt_spending.Text = "";
                    txt_trans_cost.Text = "";
                    ck_comp.Checked = false;

                }
                else
                {
                    MessageBox.Show("Please select an entry and check the complete travel box");
                }

            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
