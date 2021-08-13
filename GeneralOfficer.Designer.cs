
namespace BankManagement
{
    partial class GeneralOfficer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralOfficer));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveOfficer = new System.Windows.Forms.Button();
            this.btnUpdateOfficer = new System.Windows.Forms.Button();
            this.btnInsertOfficer = new System.Windows.Forms.Button();
            this.btnSearchGeneralOfficer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrideView = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Officer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.btnRemoveOfficer);
            this.panel2.Controls.Add(this.btnUpdateOfficer);
            this.panel2.Controls.Add(this.btnInsertOfficer);
            this.panel2.Controls.Add(this.btnSearchGeneralOfficer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 469);
            this.panel2.TabIndex = 3;
            // 
            // btnRemoveOfficer
            // 
            this.btnRemoveOfficer.BackColor = System.Drawing.Color.Teal;
            this.btnRemoveOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOfficer.Location = new System.Drawing.Point(0, 232);
            this.btnRemoveOfficer.Name = "btnRemoveOfficer";
            this.btnRemoveOfficer.Size = new System.Drawing.Size(170, 43);
            this.btnRemoveOfficer.TabIndex = 0;
            this.btnRemoveOfficer.Text = "Remove";
            this.btnRemoveOfficer.UseVisualStyleBackColor = false;
            this.btnRemoveOfficer.Click += new System.EventHandler(this.btnRemoveOfficer_Click);
            // 
            // btnUpdateOfficer
            // 
            this.btnUpdateOfficer.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOfficer.Location = new System.Drawing.Point(0, 183);
            this.btnUpdateOfficer.Name = "btnUpdateOfficer";
            this.btnUpdateOfficer.Size = new System.Drawing.Size(170, 43);
            this.btnUpdateOfficer.TabIndex = 0;
            this.btnUpdateOfficer.Text = "Update";
            this.btnUpdateOfficer.UseVisualStyleBackColor = false;
            this.btnUpdateOfficer.Click += new System.EventHandler(this.btnUpdateOfficer_Click);
            // 
            // btnInsertOfficer
            // 
            this.btnInsertOfficer.BackColor = System.Drawing.Color.Teal;
            this.btnInsertOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOfficer.Location = new System.Drawing.Point(0, 134);
            this.btnInsertOfficer.Name = "btnInsertOfficer";
            this.btnInsertOfficer.Size = new System.Drawing.Size(170, 43);
            this.btnInsertOfficer.TabIndex = 0;
            this.btnInsertOfficer.Text = "Insert";
            this.btnInsertOfficer.UseVisualStyleBackColor = false;
            this.btnInsertOfficer.Click += new System.EventHandler(this.btnInsertOfficer_Click);
            // 
            // btnSearchGeneralOfficer
            // 
            this.btnSearchGeneralOfficer.BackColor = System.Drawing.Color.Teal;
            this.btnSearchGeneralOfficer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchGeneralOfficer.BackgroundImage")));
            this.btnSearchGeneralOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGeneralOfficer.Location = new System.Drawing.Point(0, 281);
            this.btnSearchGeneralOfficer.Name = "btnSearchGeneralOfficer";
            this.btnSearchGeneralOfficer.Size = new System.Drawing.Size(170, 43);
            this.btnSearchGeneralOfficer.TabIndex = 0;
            this.btnSearchGeneralOfficer.Text = "Search";
            this.btnSearchGeneralOfficer.UseVisualStyleBackColor = false;
            this.btnSearchGeneralOfficer.Click += new System.EventHandler(this.btnSearchGeneralOfficer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 76);
            this.panel1.TabIndex = 2;
            // 
            // panelGrideView
            // 
            this.panelGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrideView.Location = new System.Drawing.Point(170, 76);
            this.panelGrideView.Name = "panelGrideView";
            this.panelGrideView.Size = new System.Drawing.Size(662, 469);
            this.panelGrideView.TabIndex = 4;
            // 
            // GeneralOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 545);
            this.Controls.Add(this.panelGrideView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralOfficer";
            this.Text = "GeneralOfficer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralOfficer_FormClosed_1);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchGeneralOfficer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveOfficer;
        private System.Windows.Forms.Button btnUpdateOfficer;
        private System.Windows.Forms.Button btnInsertOfficer;
        private System.Windows.Forms.Panel panelGrideView;
    }
}