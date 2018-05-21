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
    public partial class frm_view : Form
    {
        
        public frm_view()
        {
            InitializeComponent();
            Form_Methods.GetIDs(cmb_id);
            string mainID = cmb_id.Text;
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string mainID = cmb_id.Text;
            string pathfile = @"\\images\" + mainID + @"\\1.jpg";
            pic1.ImageLocation = Application.StartupPath + pathfile;
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pathfile = @"\\images\" + mainID + @"\\2.jpg";
            pic_2.ImageLocation = Application.StartupPath + pathfile;
            pic_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pathfile = @"\\images\" + mainID + @"\\3.jpg";
            pic_3.ImageLocation = Application.StartupPath + pathfile;
            pic_3.SizeMode = PictureBoxSizeMode.StretchImage;
            pathfile = @"\\images\" + mainID + @"\\4.jpg";
            pic_4.ImageLocation = Application.StartupPath + pathfile;
            pic_4.SizeMode = PictureBoxSizeMode.StretchImage;
            pathfile = @"\\images\" + mainID + @"\\5.jpg";
            pic_5.ImageLocation = Application.StartupPath + pathfile;
            pic_5.SizeMode = PictureBoxSizeMode.StretchImage;
            pathfile = @"\\images\" + mainID + @"\\6.jpg";
            pic_6.ImageLocation = Application.StartupPath + pathfile;
            pic_6.SizeMode = PictureBoxSizeMode.StretchImage;


            Form_Methods.loadHousing(cmb_id.Text, lbl_housing);
            Form_Methods.loadRoutes(cmb_id.Text, lbl_routes);
            Form_Methods.loadDest(cmb_id.Text, txt_dest, txt_start_date, txt_end_date, txt_start_loc, txt_no_pers, txt_notes);
            Form_Methods.getCosts(cmb_id.Text, lbl_est_housing, lbl_est_trans, lbl_est_spending, lbl_est_total, "estimate");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_view_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
