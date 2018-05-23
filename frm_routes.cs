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
        bool flag = false;
        public frm_routes()
        {
            InitializeComponent();
            //try
            //{

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            Form_Methods.GetIDs(comb_id);
            pictureBox1.Image = Resource1._2_2;
            txt_via.Items.Add("Bus");
            txt_via.Items.Add("Train");
            txt_via.Items.Add("Plane");
            txt_via.Items.Add("Car");
        }
               
        private void btn_add1_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                Form_Methods.AddRoutes(comb_id.Text, txt_from.Text, txt_to.Text, txt_via.Text, Int32.Parse(txt_transp_cost.Text), ck_return);
                if (ck_return.Checked)
                {
                    total += Int32.Parse(txt_transp_cost.Text);
                }
                else
                {
                    total += (Int32.Parse(txt_transp_cost.Text) * 2);
                }
                MessageBox.Show("Route Added");
                txt_from.Text = "";
                txt_to.Text = "";
                txt_via.Text = "";
                txt_transp_cost.Text = "";
                ck_return.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (total == 0 && flag == false)
            {
                
                this.Close();
            }

            else if (total == 0 && flag == true)
            {
                try
                {
                    Form_Methods.AddSpending(comb_id.Text, 0, "transport");
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
                    int big_total = total * Form_Methods.getPeople(comb_id.Text);
                    Form_Methods.AddSpending(comb_id.Text, big_total, "transport");
                    
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
