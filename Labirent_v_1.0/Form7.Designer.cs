namespace Labirent_v_1._0
{
    partial class Form7
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
            this.pb_menu_don = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_don)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_menu_don
            // 
            this.pb_menu_don.BackColor = System.Drawing.Color.Transparent;
            this.pb_menu_don.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_menu_don.Image = global::Labirent_v_1._0.Properties.Resources.menu_don1;
            this.pb_menu_don.Location = new System.Drawing.Point(125, 450);
            this.pb_menu_don.Name = "pb_menu_don";
            this.pb_menu_don.Size = new System.Drawing.Size(93, 38);
            this.pb_menu_don.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_menu_don.TabIndex = 0;
            this.pb_menu_don.TabStop = false;
            this.pb_menu_don.Click += new System.EventHandler(this.pb_menu_don_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Labirent_v_1._0.Properties.Resources.form_cik11;
            this.pictureBox1.Location = new System.Drawing.Point(244, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.nasiloynanir;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_menu_don);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_don)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_menu_don;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}