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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        

       
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_dest addform = new frm_add_dest();
            addform.MdiParent = this;
            addform.Show();
        }

        private void addRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_routes addroutes = new frm_routes();
            addroutes.MdiParent = this;
            addroutes.Show();

        }

        private void addHousingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_housing addhousing = new frm_housing();
            addhousing.MdiParent = this;
            addhousing.Show();
        }

        private void addCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_est_expense exp = new frm_est_expense();
            exp.MdiParent = this;
            exp.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view view = new frm_view();
            view.MdiParent = this;
            view.Show();

        }
    }
}
