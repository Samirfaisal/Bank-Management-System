
namespace BankManagement
{
    partial class OfficerUpdateUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeachForUpdateOfficer = new System.Windows.Forms.TextBox();
            this.btnUpdateOfficer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerAccountNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerPhoneNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerRole = new System.Windows.Forms.TextBox();
            this.dtpUpdateOfficer = new System.Windows.Forms.DateTimePicker();
            this.dgvUpdateOfficer = new System.Windows.Forms.DataGridView();
            this.O_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUpdateOfficer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 244);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.dtpUpdateOfficer);
            this.panel2.Controls.Add(this.txtUpdateOfficerAccountNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUpdateOfficerRole);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtUpdateOfficerPhoneNo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtUpdateOfficerAddress);
            this.panel2.Controls.Add(this.txtUpdateOfficerPassword);
            this.panel2.Controls.Add(this.txtUpdateOfficerAccountName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUpdateOfficerId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnUpdateOfficer);
            this.panel2.Controls.Add(this.txtSeachForUpdateOfficer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 219);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Account No";
            // 
            // txtSeachForUpdateOfficer
            // 
            this.txtSeachForUpdateOfficer.Location = new System.Drawing.Point(192, 194);
            this.txtSeachForUpdateOfficer.Name = "txtSeachForUpdateOfficer";
            this.txtSeachForUpdateOfficer.Size = new System.Drawing.Size(100, 22);
            this.txtSeachForUpdateOfficer.TabIndex = 1;
            this.txtSeachForUpdateOfficer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpdateOfficer
            // 
            this.btnUpdateOfficer.Location = new System.Drawing.Point(556, 176);
            this.btnUpdateOfficer.Name = "btnUpdateOfficer";
            this.btnUpdateOfficer.Size = new System.Drawing.Size(91, 40);
            this.btnUpdateOfficer.TabIndex = 2;
            this.btnUpdateOfficer.Text = "Update";
            this.btnUpdateOfficer.UseVisualStyleBackColor = true;
            this.btnUpdateOfficer.Click += new System.EventHandler(this.btnUpdateOfficer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "General Officer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "O_Id";
            // 
            // txtUpdateOfficerId
            // 
            this.txtUpdateOfficerId.Location = new System.Drawing.Point(117, 51);
            this.txtUpdateOfficerId.Name = "txtUpdateOfficerId";
            this.txtUpdateOfficerId.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "O_Password";
            // 
            // txtUpdateOfficerPassword
            // 
            this.txtUpdateOfficerPassword.Location = new System.Drawing.Point(117, 100);
            this.txtUpdateOfficerPassword.Name = "txtUpdateOfficerPassword";
            this.txtUpdateOfficerPassword.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acc No";
            // 
            // txtUpdateOfficerAccountNo
            // 
            this.txtUpdateOfficerAccountNo.Location = new System.Drawing.Point(117, 149);
            this.txtUpdateOfficerAccountNo.Name = "txtUpdateOfficerAccountNo";
            this.txtUpdateOfficerAccountNo.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerAccountNo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Acc Name";
            // 
            // txtUpdateOfficerAccountName
            // 
            this.txtUpdateOfficerAccountName.Location = new System.Drawing.Point(347, 51);
            this.txtUpdateOfficerAccountName.Name = "txtUpdateOfficerAccountName";
            this.txtUpdateOfficerAccountName.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerAccountName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone No";
            // 
            // txtUpdateOfficerPhoneNo
            // 
            this.txtUpdateOfficerPhoneNo.Location = new System.Drawing.Point(347, 100);
            this.txtUpdateOfficerPhoneNo.Name = "txtUpdateOfficerPhoneNo";
            this.txtUpdateOfficerPhoneNo.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerPhoneNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Create Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "O_Address";
            // 
            // txtUpdateOfficerAddress
            // 
            this.txtUpdateOfficerAddress.Location = new System.Drawing.Point(547, 51);
            this.txtUpdateOfficerAddress.Name = "txtUpdateOfficerAddress";
            this.txtUpdateOfficerAddress.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerAddress.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Role";
            // 
            // txtUpdateOfficerRole
            // 
            this.txtUpdateOfficerRole.Location = new System.Drawing.Point(547, 100);
            this.txtUpdateOfficerRole.Name = "txtUpdateOfficerRole";
            this.txtUpdateOfficerRole.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateOfficerRole.TabIndex = 5;
            // 
            // dtpUpdateOfficer
            // 
            this.dtpUpdateOfficer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdateOfficer.Location = new System.Drawing.Point(347, 152);
            this.dtpUpdateOfficer.Name = "dtpUpdateOfficer";
            this.dtpUpdateOfficer.Size = new System.Drawing.Size(100, 22);
            this.dtpUpdateOfficer.TabIndex = 6;
            // 
            // dgvUpdateOfficer
            // 
            this.dgvUpdateOfficer.AllowUserToAddRows = false;
            this.dgvUpdateOfficer.AllowUserToDeleteRows = false;
            this.dgvUpdateOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O_Id,
            this.O_Password,
            this.Account_No,
            this.Account_Name,
            this.AccountCreateDate,
            this.C_PhoneNo,
            this.C_Address,
            this.Role});
            this.dgvUpdateOfficer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpdateOfficer.Location = new System.Drawing.Point(0, 0);
            this.dgvUpdateOfficer.Name = "dgvUpdateOfficer";
            this.dgvUpdateOfficer.ReadOnly = true;
            this.dgvUpdateOfficer.RowHeadersWidth = 51;
            this.dgvUpdateOfficer.RowTemplate.Height = 24;
            this.dgvUpdateOfficer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdateOfficer.Size = new System.Drawing.Size(662, 244);
            this.dgvUpdateOfficer.TabIndex = 0;
            this.dgvUpdateOfficer.DoubleClick += new System.EventHandler(this.dgvUpdateOfficer_DoubleClick);
            // 
            // O_Id
            // 
            this.O_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.O_Id.DataPropertyName = "O_Id";
            this.O_Id.HeaderText = "Id";
            this.O_Id.MinimumWidth = 6;
            this.O_Id.Name = "O_Id";
            this.O_Id.ReadOnly = true;
            // 
            // O_Password
            // 
            this.O_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.O_Password.DataPropertyName = "O_Password";
            this.O_Password.HeaderText = "Password";
            this.O_Password.MinimumWidth = 6;
            this.O_Password.Name = "O_Password";
            this.O_Password.ReadOnly = true;
            // 
            // Account_No
            // 
            this.Account_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Account No";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.ReadOnly = true;
            // 
            // Account_Name
            // 
            this.Account_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_Name.DataPropertyName = "Account_Name";
            this.Account_Name.HeaderText = "Account Name";
            this.Account_Name.MinimumWidth = 6;
            this.Account_Name.Name = "Account_Name";
            this.Account_Name.ReadOnly = true;
            // 
            // AccountCreateDate
            // 
            this.AccountCreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountCreateDate.DataPropertyName = "AccountCreateDate";
            this.AccountCreateDate.HeaderText = "Create Date";
            this.AccountCreateDate.MinimumWidth = 6;
            this.AccountCreateDate.Name = "AccountCreateDate";
            this.AccountCreateDate.ReadOnly = true;
            // 
            // C_PhoneNo
            // 
            this.C_PhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_PhoneNo.DataPropertyName = "C_PhoneNo";
            this.C_PhoneNo.HeaderText = "Phone No";
            this.C_PhoneNo.MinimumWidth = 6;
            this.C_PhoneNo.Name = "C_PhoneNo";
            this.C_PhoneNo.ReadOnly = true;
            // 
            // C_Address
            // 
            this.C_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Address.DataPropertyName = "C_Address";
            this.C_Address.HeaderText = "Address";
            this.C_Address.MinimumWidth = 6;
            this.C_Address.Name = "C_Address";
            this.C_Address.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // OfficerUpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OfficerUpdateUserControl";
            this.Size = new System.Drawing.Size(662, 469);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateOfficer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateOfficer;
        private System.Windows.Forms.TextBox txtSeachForUpdateOfficer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateOfficerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateOfficerAccountNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateOfficerRole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateOfficerPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateOfficerAddress;
        private System.Windows.Forms.TextBox txtUpdateOfficerPassword;
        private System.Windows.Forms.TextBox txtUpdateOfficerAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUpdateOfficer;
        private System.Windows.Forms.DataGridView dgvUpdateOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
