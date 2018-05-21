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
    public partial class frm_routes : Form
    {
        int total = 0;
        public frm_routes()
        {
            InitializeComponent();
            Form_Methods.GetIDs(comb_id);
            txt_via.Items.Add("Bus");
            txt_via.Items.Add("Train");
            txt_via.Items.Add("Plane");
            txt_via.Items.Add("Car");
        }
               
        private void btn_add1_Click(object sender, EventArgs e)
        {
            Form_Methods.AddRoutes(comb_id.Text, txt_from.Text, txt_to.Text, txt_via.Text,Int32.Parse(txt_transp_cost.Text), ck_return);
            if (ck_return.Checked)
            {
                total += Int32.Parse(txt_transp_cost.Text);
            }
            else
            {
                total += (Int32.Parse(txt_transp_cost.Text) *2);
            }
            MessageBox.Show(total.ToString());
            //Form_Methods.AddSpending(comb_id.Text, Int32.Parse(txt_transp_cost.Text), "transport");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                this.Close();
            }
            else
            {
                Form_Methods.AddSpending(comb_id.Text, total, "transport");
                this.Close();
            }
        }
    }
}
