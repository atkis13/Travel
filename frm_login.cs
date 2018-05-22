﻿using System;
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
    public partial class frm_login : Form
    {
        DBConnection conn;
        public frm_login()
        {
            InitializeComponent();
            pictureBox1.Image = Resource1._6;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_username.Text;
            string pass = txt_password.Text;

            try
            {
                conn = new DBConnection();
                if (user == conn.Username && pass == conn.Password)
                {


                    conn.Open();

                    this.Hide();
                    frm_main main = new frm_main();
                    main.Show();

                }

                else
                {
                    MessageBox.Show("Ivalid username or password");
                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
    

