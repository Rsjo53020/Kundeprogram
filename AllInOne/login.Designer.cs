﻿namespace GUI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            bt_LogIn = new Button();
            tb_UserName = new TextBox();
            tb_password = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(302, 356);
            label1.Name = "label1";
            label1.Size = new Size(134, 40);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 492);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 685);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 820);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 4;
            label2.Text = "Clear fields";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(755, 12);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 5;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // bt_LogIn
            // 
            bt_LogIn.BackColor = Color.DarkOrchid;
            bt_LogIn.Font = new Font("Arial", 28.125F, FontStyle.Bold, GraphicsUnit.Point);
            bt_LogIn.ForeColor = SystemColors.ActiveCaptionText;
            bt_LogIn.Location = new Point(108, 930);
            bt_LogIn.Name = "bt_LogIn";
            bt_LogIn.Size = new Size(652, 104);
            bt_LogIn.TabIndex = 6;
            bt_LogIn.Text = "LOG IN";
            bt_LogIn.UseVisualStyleBackColor = false;
            bt_LogIn.Click += bt_LogIn_Click;
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(170, 540);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(590, 26);
            tb_UserName.TabIndex = 7;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(170, 733);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(590, 26);
            tb_password.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(23, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 10);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(23, 783);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 10);
            panel2.TabIndex = 10;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 941);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tb_password);
            Controls.Add(tb_UserName);
            Controls.Add(bt_LogIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Button bt_LogIn;
        private TextBox tb_UserName;
        private TextBox tb_password;
        private Panel panel1;
        private Panel panel2;
    }
}