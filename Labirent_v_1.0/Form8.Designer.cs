namespace Labirent_v_1._0
{
    partial class Form8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_menu_don = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_don)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Labirent_v_1._0.Properties.Resources.form_cik11;
            this.pictureBox1.Location = new System.Drawing.Point(231, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_menu_don
            // 
            this.pb_menu_don.BackColor = System.Drawing.Color.Transparent;
            this.pb_menu_don.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_menu_don.Image = global::Labirent_v_1._0.Properties.Resources.menu_don1;
            this.pb_menu_don.Location = new System.Drawing.Point(112, 399);
            this.pb_menu_don.Name = "pb_menu_don";
            this.pb_menu_don.Size = new System.Drawing.Size(93, 38);
            this.pb_menu_don.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_menu_don.TabIndex = 2;
            this.pb_menu_don.TabStop = false;
            this.pb_menu_don.Click += new System.EventHandler(this.pb_menu_don_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirent_v_1._0.Properties.Resources.hakkinda;
            this.ClientSize = new System.Drawing.Size(500, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_menu_don);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_don)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_menu_don;
    }
}