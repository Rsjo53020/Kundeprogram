﻿namespace AllInOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BTN_AddCustomer = new Button();
            BTN_ShowOneCustomer = new Button();
            BTN_ShowAllCustomer = new Button();
            BTN_UpdateCustome = new Button();
            BTN_DeletedCustome = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TB_id = new TextBox();
            TB_PhoneNr = new TextBox();
            TB_FirstName = new TextBox();
            LB_INFO = new ListBox();
            label4 = new Label();
            TB_LastName = new TextBox();
            label5 = new Label();
            TB_Mail = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phonenumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BTN_AddCustomer
            // 
            BTN_AddCustomer.Location = new Point(33, 214);
            BTN_AddCustomer.Margin = new Padding(1, 1, 1, 1);
            BTN_AddCustomer.Name = "BTN_AddCustomer";
            BTN_AddCustomer.Size = new Size(123, 27);
            BTN_AddCustomer.TabIndex = 0;
            BTN_AddCustomer.Text = "Tilføje Kunde";
            BTN_AddCustomer.UseVisualStyleBackColor = true;
            BTN_AddCustomer.Click += BTN_AddCustomer_Click;
            // 
            // BTN_ShowOneCustomer
            // 
            BTN_ShowOneCustomer.Location = new Point(174, 214);
            BTN_ShowOneCustomer.Margin = new Padding(1, 1, 1, 1);
            BTN_ShowOneCustomer.Name = "BTN_ShowOneCustomer";
            BTN_ShowOneCustomer.Size = new Size(123, 27);
            BTN_ShowOneCustomer.TabIndex = 1;
            BTN_ShowOneCustomer.Text = "Vis Kunde";
            BTN_ShowOneCustomer.UseVisualStyleBackColor = true;
            BTN_ShowOneCustomer.Click += BTN_ShowOneCustomer_Click;
            // 
            // BTN_ShowAllCustomer
            // 
            BTN_ShowAllCustomer.Location = new Point(33, 257);
            BTN_ShowAllCustomer.Margin = new Padding(1, 1, 1, 1);
            BTN_ShowAllCustomer.Name = "BTN_ShowAllCustomer";
            BTN_ShowAllCustomer.Size = new Size(123, 27);
            BTN_ShowAllCustomer.TabIndex = 2;
            BTN_ShowAllCustomer.Text = "Vis Alle Kunder";
            BTN_ShowAllCustomer.UseVisualStyleBackColor = true;
            BTN_ShowAllCustomer.Click += BTN_ShowAllCustomer_Click;
            // 
            // BTN_UpdateCustome
            // 
            BTN_UpdateCustome.Location = new Point(174, 257);
            BTN_UpdateCustome.Margin = new Padding(1, 1, 1, 1);
            BTN_UpdateCustome.Name = "BTN_UpdateCustome";
            BTN_UpdateCustome.Size = new Size(123, 27);
            BTN_UpdateCustome.TabIndex = 3;
            BTN_UpdateCustome.Text = "Opdater Kunde";
            BTN_UpdateCustome.UseVisualStyleBackColor = true;
            BTN_UpdateCustome.Click += BTN_UpdateCustome_Click;
            // 
            // BTN_DeletedCustome
            // 
            BTN_DeletedCustome.Location = new Point(174, 303);
            BTN_DeletedCustome.Margin = new Padding(1, 1, 1, 1);
            BTN_DeletedCustome.Name = "BTN_DeletedCustome";
            BTN_DeletedCustome.Size = new Size(123, 27);
            BTN_DeletedCustome.TabIndex = 4;
            BTN_DeletedCustome.Text = "Slet Kunde";
            BTN_DeletedCustome.UseVisualStyleBackColor = true;
            BTN_DeletedCustome.Click += BTN_DeletedCustome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 5;
            label1.Text = "ID.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 59);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefon nr.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 90);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Fornavn:";
            // 
            // TB_id
            // 
            TB_id.Location = new Point(139, 28);
            TB_id.Margin = new Padding(1, 1, 1, 1);
            TB_id.Name = "TB_id";
            TB_id.Size = new Size(159, 23);
            TB_id.TabIndex = 8;
            // 
            // TB_PhoneNr
            // 
            TB_PhoneNr.Location = new Point(139, 56);
            TB_PhoneNr.Margin = new Padding(1, 1, 1, 1);
            TB_PhoneNr.Name = "TB_PhoneNr";
            TB_PhoneNr.Size = new Size(159, 23);
            TB_PhoneNr.TabIndex = 9;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(139, 87);
            TB_FirstName.Margin = new Padding(1, 1, 1, 1);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.Size = new Size(159, 23);
            TB_FirstName.TabIndex = 10;
            // 
            // LB_INFO
            // 
            LB_INFO.FormattingEnabled = true;
            LB_INFO.ItemHeight = 15;
            LB_INFO.Location = new Point(432, 27);
            LB_INFO.Margin = new Padding(1, 1, 1, 1);
            LB_INFO.Name = "LB_INFO";
            LB_INFO.Size = new Size(628, 64);
            LB_INFO.TabIndex = 11;
            LB_INFO.SelectedIndexChanged += LB_INFO_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 28);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 12;
            label4.Text = "INFO:";
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(139, 119);
            TB_LastName.Margin = new Padding(1, 1, 1, 1);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.Size = new Size(159, 23);
            TB_LastName.TabIndex = 14;
            TB_LastName.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 123);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Efternavn:";
            // 
            // TB_Mail
            // 
            TB_Mail.Location = new Point(139, 153);
            TB_Mail.Margin = new Padding(1, 1, 1, 1);
            TB_Mail.Name = "TB_Mail";
            TB_Mail.Size = new Size(159, 23);
            TB_Mail.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 157);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 15;
            label6.Text = "Mail:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phonenumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(332, 101);
            dataGridView1.Margin = new Padding(1, 1, 1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(724, 319);
            dataGridView1.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            phonenumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            phonenumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn.MinimumWidth = 10;
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            adressDataGridViewTextBoxColumn.ReadOnly = true;
            adressDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(RePo.ModelsRePo.Customer);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 425);
            Controls.Add(dataGridView1);
            Controls.Add(TB_Mail);
            Controls.Add(label6);
            Controls.Add(TB_LastName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LB_INFO);
            Controls.Add(TB_FirstName);
            Controls.Add(TB_PhoneNr);
            Controls.Add(TB_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTN_DeletedCustome);
            Controls.Add(BTN_UpdateCustome);
            Controls.Add(BTN_ShowAllCustomer);
            Controls.Add(BTN_ShowOneCustomer);
            Controls.Add(BTN_AddCustomer);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_AddCustomer;
        private Button BTN_ShowOneCustomer;
        private Button BTN_ShowAllCustomer;
        private Button BTN_UpdateCustome;
        private Button BTN_DeletedCustome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TB_id;
        private TextBox TB_PhoneNr;
        private TextBox TB_FirstName;
        private ListBox LB_INFO;
        private Label label4;
        private TextBox TB_LastName;
        private Label label5;
        private TextBox TB_Mail;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
    }
}