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
    public partial class frm_housing : Form
    {
        int total = 0;
        bool flag = false;
        public frm_housing()
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
            
            pictureBox1.Image = Resource1._1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                Form_Methods.AddHousing(cmb_id.Text, txt_housing_loc.Text, date_in, date_out, Int32.Parse(txt_cost.Text));
                total += (date_out.Value.Day - date_in.Value.Day) * Int32.Parse(txt_cost.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Housing Added");
            txt_housing_loc.Text = "";
            txt_cost.Text = "";
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(total == 0 && flag == false)
            {
                this.Close();
            }
            else if (total == 0 && flag == true)
            {
                try
                {
                    Form_Methods.AddSpending(cmb_id.Text, 0, "housing");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                this.Close();
            }
            else
            {
                try
                {
                    Form_Methods.AddSpending(cmb_id.Text, total, "housing");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.Close();
            }
           
        }
    }
}
