namespace GUI
{
    partial class Customer
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_ID = new TextBox();
            tb_PhoneNr = new TextBox();
            tb_FirstName = new TextBox();
            tb_LastName = new TextBox();
            tb_mail = new TextBox();
            btn_UpdateCustomer = new Button();
            btn_ShowAllCustomer = new Button();
            btn_ShowOneCustomer = new Button();
            btn_AddCustomer = new Button();
            btn_DeletedCustomer = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phonenumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(31, 18);
            label1.TabIndex = 0;
            label1.Text = "ID.:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 65);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 1;
            label2.Text = "Telefon nr.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 3;
            label3.Text = "Efternavn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 92);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 2;
            label4.Text = "Fornavn:";
            label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 161);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 7;
            label5.Text = "Mail:";
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(153, 25);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(140, 26);
            tb_ID.TabIndex = 8;
            // 
            // tb_PhoneNr
            // 
            tb_PhoneNr.Location = new Point(153, 57);
            tb_PhoneNr.Name = "tb_PhoneNr";
            tb_PhoneNr.Size = new Size(140, 26);
            tb_PhoneNr.TabIndex = 9;
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(153, 89);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(140, 26);
            tb_FirstName.TabIndex = 10;
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(153, 121);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(140, 26);
            tb_LastName.TabIndex = 11;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(153, 153);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(140, 26);
            tb_mail.TabIndex = 12;
            // 
            // btn_UpdateCustomer
            // 
            btn_UpdateCustomer.BackColor = Color.YellowGreen;
            btn_UpdateCustomer.Location = new Point(188, 289);
            btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            btn_UpdateCustomer.Size = new Size(140, 46);
            btn_UpdateCustomer.TabIndex = 13;
            btn_UpdateCustomer.Text = "Opdater";
            btn_UpdateCustomer.UseVisualStyleBackColor = false;
            btn_UpdateCustomer.Click += btn_UpdateCustomer_Click;
            // 
            // btn_ShowAllCustomer
            // 
            btn_ShowAllCustomer.Location = new Point(188, 225);
            btn_ShowAllCustomer.Name = "btn_ShowAllCustomer";
            btn_ShowAllCustomer.Size = new Size(140, 26);
            btn_ShowAllCustomer.TabIndex = 14;
            btn_ShowAllCustomer.Text = "Vis alle";
            btn_ShowAllCustomer.UseVisualStyleBackColor = true;
            btn_ShowAllCustomer.Click += btn_ShowAllCustomer_Click;
            // 
            // btn_ShowOneCustomer
            // 
            btn_ShowOneCustomer.Location = new Point(28, 225);
            btn_ShowOneCustomer.Name = "btn_ShowOneCustomer";
            btn_ShowOneCustomer.Size = new Size(140, 26);
            btn_ShowOneCustomer.TabIndex = 16;
            btn_ShowOneCustomer.Text = "Vis en";
            btn_ShowOneCustomer.UseVisualStyleBackColor = true;
            btn_ShowOneCustomer.Click += btn_ShowOneCustomer_Click;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.BackColor = Color.YellowGreen;
            btn_AddCustomer.Location = new Point(28, 289);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(140, 46);
            btn_AddCustomer.TabIndex = 15;
            btn_AddCustomer.Text = "Tilføje";
            btn_AddCustomer.UseVisualStyleBackColor = false;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // btn_DeletedCustomer
            // 
            btn_DeletedCustomer.BackColor = Color.Red;
            btn_DeletedCustomer.Location = new Point(28, 449);
            btn_DeletedCustomer.Name = "btn_DeletedCustomer";
            btn_DeletedCustomer.Size = new Size(140, 26);
            btn_DeletedCustomer.TabIndex = 17;
            btn_DeletedCustomer.Text = "Slet";
            btn_DeletedCustomer.UseVisualStyleBackColor = false;
            btn_DeletedCustomer.Click += btn_DeletedCustomer_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_ID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_mail);
            groupBox1.Controls.Add(tb_PhoneNr);
            groupBox1.Controls.Add(tb_LastName);
            groupBox1.Controls.Add(tb_FirstName);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 188);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kunde Oplysninger";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phonenumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(357, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 451);
            dataGridView1.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(RePo.ModelsRePo.Customer);
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 487);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btn_DeletedCustomer);
            Controls.Add(btn_ShowOneCustomer);
            Controls.Add(btn_AddCustomer);
            Controls.Add(btn_ShowAllCustomer);
            Controls.Add(btn_UpdateCustomer);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_ID;
        private TextBox tb_PhoneNr;
        private TextBox tb_FirstName;
        private TextBox tb_LastName;
        private TextBox tb_mail;
        private Button btn_UpdateCustomer;
        private Button btn_ShowAllCustomer;
        private Button btn_ShowOneCustomer;
        private Button btn_AddCustomer;
        private Button btn_DeletedCustomer;
        private GroupBox groupBox1;
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