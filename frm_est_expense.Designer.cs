namespace Travel
{
    partial class frm_est_expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.btn_est = new System.Windows.Forms.Button();
            this.lbl_est = new System.Windows.Forms.Label();
            this.btn_add_est = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_id
            // 
            this.cmb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(80, 84);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(141, 24);
            this.cmb_id.TabIndex = 0;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // btn_est
            // 
            this.btn_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_est.Location = new System.Drawing.Point(106, 125);
            this.btn_est.Name = "btn_est";
            this.btn_est.Size = new System.Drawing.Size(75, 27);
            this.btn_est.TabIndex = 1;
            this.btn_est.Text = "Estimate";
            this.btn_est.UseVisualStyleBackColor = true;
            this.btn_est.Click += new System.EventHandler(this.btn_est_Click);
            // 
            // lbl_est
            // 
            this.lbl_est.AutoSize = true;
            this.lbl_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_est.Location = new System.Drawing.Point(122, 178);
            this.lbl_est.Name = "lbl_est";
            this.lbl_est.Size = new System.Drawing.Size(46, 17);
            this.lbl_est.TabIndex = 2;
            this.lbl_est.Text = "label1";
            // 
            // btn_add_est
            // 
            this.btn_add_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_est.Location = new System.Drawing.Point(93, 232);
            this.btn_add_est.Name = "btn_add_est";
            this.btn_add_est.Size = new System.Drawing.Size(99, 27);
            this.btn_add_est.TabIndex = 3;
            this.btn_add_est.Text = "Add Estimate";
            this.btn_add_est.UseVisualStyleBackColor = true;
            this.btn_add_est.Click += new System.EventHandler(this.btn_add_est_Click);
            // 
            // frm_est_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 310);
            this.Controls.Add(this.btn_add_est);
            this.Controls.Add(this.lbl_est);
            this.Controls.Add(this.btn_est);
            this.Controls.Add(this.cmb_id);
            this.Name = "frm_est_expense";
            this.Text = "frm_est_expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Button btn_est;
        private System.Windows.Forms.Label lbl_est;
        private System.Windows.Forms.Button btn_add_est;
    }
}