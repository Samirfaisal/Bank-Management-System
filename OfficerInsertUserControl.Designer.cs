
namespace BankManagement
{
    partial class OfficerInsertUserControl
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
            this.dgvInsertOfficer = new System.Windows.Forms.DataGridView();
            this.btnInsertOfficer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtO_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtO_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccount_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC_PhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtC_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpInsertOfficer = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvInsertOfficer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 318);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.dtpInsertOfficer);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtC_PhoneNo);
            this.panel2.Controls.Add(this.txtAccount_No);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtRole);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtC_Address);
            this.panel2.Controls.Add(this.txtO_Password);
            this.panel2.Controls.Add(this.txtAccount_Name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtO_Id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnInsertOfficer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 145);
            this.panel2.TabIndex = 1;
            // 
            // dgvInsertOfficer
            // 
            this.dgvInsertOfficer.AllowUserToAddRows = false;
            this.dgvInsertOfficer.AllowUserToDeleteRows = false;
            this.dgvInsertOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsertOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O_Id,
            this.O_Password,
            this.Account_No,
            this.Account_Name,
            this.AccountCreateDate,
            this.C_PhoneNo,
            this.C_Address,
            this.Role});
            this.dgvInsertOfficer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsertOfficer.Location = new System.Drawing.Point(0, 0);
            this.dgvInsertOfficer.Name = "dgvInsertOfficer";
            this.dgvInsertOfficer.ReadOnly = true;
            this.dgvInsertOfficer.RowHeadersWidth = 51;
            this.dgvInsertOfficer.RowTemplate.Height = 24;
            this.dgvInsertOfficer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsertOfficer.Size = new System.Drawing.Size(662, 318);
            this.dgvInsertOfficer.TabIndex = 0;
            // 
            // btnInsertOfficer
            // 
            this.btnInsertOfficer.Location = new System.Drawing.Point(513, 113);
            this.btnInsertOfficer.Name = "btnInsertOfficer";
            this.btnInsertOfficer.Size = new System.Drawing.Size(100, 27);
            this.btnInsertOfficer.TabIndex = 9;
            this.btnInsertOfficer.Text = "Insert";
            this.btnInsertOfficer.UseVisualStyleBackColor = true;
            this.btnInsertOfficer.Click += new System.EventHandler(this.btnInsertOfficer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "O_Id";
            // 
            // txtO_Id
            // 
            this.txtO_Id.Location = new System.Drawing.Point(102, 42);
            this.txtO_Id.Name = "txtO_Id";
            this.txtO_Id.Size = new System.Drawing.Size(100, 22);
            this.txtO_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "O_Password";
            // 
            // txtO_Password
            // 
            this.txtO_Password.Location = new System.Drawing.Point(102, 79);
            this.txtO_Password.Name = "txtO_Password";
            this.txtO_Password.Size = new System.Drawing.Size(100, 22);
            this.txtO_Password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account_No";
            // 
            // txtAccount_No
            // 
            this.txtAccount_No.Location = new System.Drawing.Point(102, 117);
            this.txtAccount_No.Name = "txtAccount_No";
            this.txtAccount_No.Size = new System.Drawing.Size(100, 22);
            this.txtAccount_No.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Acc_Name";
            // 
            // txtAccount_Name
            // 
            this.txtAccount_Name.Location = new System.Drawing.Point(310, 39);
            this.txtAccount_Name.Name = "txtAccount_Name";
            this.txtAccount_Name.Size = new System.Drawing.Size(100, 22);
            this.txtAccount_Name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone No";
            // 
            // txtC_PhoneNo
            // 
            this.txtC_PhoneNo.Location = new System.Drawing.Point(310, 115);
            this.txtC_PhoneNo.Name = "txtC_PhoneNo";
            this.txtC_PhoneNo.Size = new System.Drawing.Size(100, 22);
            this.txtC_PhoneNo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // txtC_Address
            // 
            this.txtC_Address.Location = new System.Drawing.Point(513, 39);
            this.txtC_Address.Name = "txtC_Address";
            this.txtC_Address.Size = new System.Drawing.Size(100, 22);
            this.txtC_Address.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(513, 77);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 22);
            this.txtRole.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "General Officer";
            // 
            // dtpInsertOfficer
            // 
            this.dtpInsertOfficer.CustomFormat = "YYYY-MM-DD";
            this.dtpInsertOfficer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInsertOfficer.Location = new System.Drawing.Point(310, 78);
            this.dtpInsertOfficer.Name = "dtpInsertOfficer";
            this.dtpInsertOfficer.Size = new System.Drawing.Size(102, 22);
            this.dtpInsertOfficer.TabIndex = 10;
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
            this.Account_Name.HeaderText = "Acc Name";
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
            // OfficerInsertUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OfficerInsertUserControl";
            this.Size = new System.Drawing.Size(662, 469);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertOfficer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInsertOfficer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtC_PhoneNo;
        private System.Windows.Forms.TextBox txtAccount_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC_Address;
        private System.Windows.Forms.TextBox txtO_Password;
        private System.Windows.Forms.TextBox txtAccount_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtO_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertOfficer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpInsertOfficer;
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
