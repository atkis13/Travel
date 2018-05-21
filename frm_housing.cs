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
            Form_Methods.GetIDs(cmb_id);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            flag = true;
            Form_Methods.AddHousing(cmb_id.Text, txt_housing_loc.Text, date_in, date_out, Int32.Parse(txt_cost.Text));
            total += (date_out.Value.Day - date_in.Value.Day) * Int32.Parse(txt_cost.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(total == 0 && flag == false)
            {
                this.Close();
            }
            else if (total == 0 && flag == true)
            {
                Form_Methods.AddSpending(cmb_id.Text, 0, "housing");
                this.Close();
            }
            else
            {
                Form_Methods.AddSpending(cmb_id.Text, total, "housing");
                this.Close();
            }
           
        }
    }
}
