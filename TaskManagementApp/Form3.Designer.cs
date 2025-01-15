namespace TaskManagementApp
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.BtnTManagement = new System.Windows.Forms.Button();
            this.txtProfile = new System.Windows.Forms.Button();
            this.synchronizeTimer1 = new GHNet.Windows.Forms.SynchronizeTimer(this.components);
            this.analogueClock1 = new GHNet.Windows.Forms.AnalogueClock();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analogueClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pnl2.Controls.Add(this.analogueClock1);
            this.Pnl2.Controls.Add(this.pictureProfile);
            this.Pnl2.Controls.Add(this.label2);
            this.Pnl2.Controls.Add(this.pictureBox2);
            this.Pnl2.Controls.Add(this.label1);
            this.Pnl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl2.ForeColor = System.Drawing.Color.White;
            this.Pnl2.Location = new System.Drawing.Point(0, 0);
            this.Pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(280, 576);
            this.Pnl2.TabIndex = 3;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfile.Image")));
            this.pictureProfile.Location = new System.Drawing.Point(70, 43);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(116, 116);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfile.TabIndex = 9;
            this.pictureProfile.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to my app";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 504);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(96, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(743, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(383, 256);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(352, 52);
            this.btnHelp.TabIndex = 41;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // BtnTManagement
            // 
            this.BtnTManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnTManagement.FlatAppearance.BorderSize = 0;
            this.BtnTManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnTManagement.ForeColor = System.Drawing.Color.White;
            this.BtnTManagement.Location = new System.Drawing.Point(383, 117);
            this.BtnTManagement.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.BtnTManagement.Name = "BtnTManagement";
            this.BtnTManagement.Size = new System.Drawing.Size(352, 52);
            this.BtnTManagement.TabIndex = 40;
            this.BtnTManagement.Text = "Task Management App";
            this.BtnTManagement.UseVisualStyleBackColor = false;
            this.BtnTManagement.Click += new System.EventHandler(this.BtnTManagement_Click);
            // 
            // txtProfile
            // 
            this.txtProfile.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtProfile.FlatAppearance.BorderSize = 0;
            this.txtProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProfile.ForeColor = System.Drawing.Color.White;
            this.txtProfile.Location = new System.Drawing.Point(383, 388);
            this.txtProfile.Margin = new System.Windows.Forms.Padding(0);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(352, 52);
            this.txtProfile.TabIndex = 44;
            this.txtProfile.Text = "Profile";
            this.txtProfile.UseVisualStyleBackColor = false;
            this.txtProfile.Click += new System.EventHandler(this.txtProfile_Click);
            // 
            // analogueClock1
            // 
            this.analogueClock1.Location = new System.Drawing.Point(31, 342);
            this.analogueClock1.Name = "analogueClock1";
            this.analogueClock1.Size = new System.Drawing.Size(194, 139);
            this.analogueClock1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 576);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.BtnTManagement);
            this.Controls.Add(this.Pnl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analogueClock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button BtnTManagement;
        private System.Windows.Forms.Button txtProfile;
        private GHNet.Windows.Forms.AnalogueClock analogueClock1;
        private GHNet.Windows.Forms.SynchronizeTimer synchronizeTimer1;
    }
}