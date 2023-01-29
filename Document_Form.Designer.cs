namespace Caguisan_BMS_Test
{
    partial class Document_Form
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
            this.Resident_Record = new System.Windows.Forms.Button();
            this.Documents = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Barangay_Franchise = new System.Windows.Forms.Button();
            this.Business_Permit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Documents.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resident_Record
            // 
            this.Resident_Record.BackColor = System.Drawing.Color.Cyan;
            this.Resident_Record.FlatAppearance.BorderSize = 0;
            this.Resident_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Resident_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Resident_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resident_Record.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resident_Record.ForeColor = System.Drawing.Color.Black;
            this.Resident_Record.Location = new System.Drawing.Point(851, -3);
            this.Resident_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Resident_Record.Name = "Resident_Record";
            this.Resident_Record.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Resident_Record.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Resident_Record.Size = new System.Drawing.Size(343, 44);
            this.Resident_Record.TabIndex = 3;
            this.Resident_Record.Text = "Resident record";
            this.Resident_Record.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Resident_Record.UseVisualStyleBackColor = false;
            // 
            // Documents
            // 
            this.Documents.Controls.Add(this.metroTabPage1);
            this.Documents.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.Documents.Location = new System.Drawing.Point(-1, 41);
            this.Documents.Name = "Documents";
            this.Documents.SelectedIndex = 0;
            this.Documents.Size = new System.Drawing.Size(1195, 163);
            this.Documents.TabIndex = 4;
            this.Documents.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.Business_Permit);
            this.metroTabPage1.Controls.Add(this.Barangay_Franchise);
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1187, 124);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Documents ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(220, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "Barangay Clearance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barangay_Franchise
            // 
            this.Barangay_Franchise.BackColor = System.Drawing.SystemColors.Control;
            this.Barangay_Franchise.FlatAppearance.BorderSize = 0;
            this.Barangay_Franchise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Barangay_Franchise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Barangay_Franchise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barangay_Franchise.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barangay_Franchise.ForeColor = System.Drawing.Color.Black;
            this.Barangay_Franchise.Location = new System.Drawing.Point(228, 17);
            this.Barangay_Franchise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Barangay_Franchise.Name = "Barangay_Franchise";
            this.Barangay_Franchise.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Barangay_Franchise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Barangay_Franchise.Size = new System.Drawing.Size(220, 92);
            this.Barangay_Franchise.TabIndex = 5;
            this.Barangay_Franchise.Text = "Barangay Franchise";
            this.Barangay_Franchise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Barangay_Franchise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Barangay_Franchise.UseVisualStyleBackColor = false;
            this.Barangay_Franchise.Click += new System.EventHandler(this.button1_Click);
            // 
            // Business_Permit
            // 
            this.Business_Permit.BackColor = System.Drawing.SystemColors.Control;
            this.Business_Permit.FlatAppearance.BorderSize = 0;
            this.Business_Permit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Business_Permit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Business_Permit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Business_Permit.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Business_Permit.ForeColor = System.Drawing.Color.Black;
            this.Business_Permit.Location = new System.Drawing.Point(456, 17);
            this.Business_Permit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Business_Permit.Name = "Business_Permit";
            this.Business_Permit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Business_Permit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Business_Permit.Size = new System.Drawing.Size(220, 92);
            this.Business_Permit.TabIndex = 5;
            this.Business_Permit.Text = "Business Permits";
            this.Business_Permit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Business_Permit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Business_Permit.UseVisualStyleBackColor = false;
            this.Business_Permit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "";
            // 
            // Document_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 653);
            this.Controls.Add(this.Documents);
            this.Controls.Add(this.Resident_Record);
            this.Name = "Document_Form";
            this.Text = "Barangay Document Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Document_Form_Load);
            this.Documents.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Resident_Record;
        private MetroFramework.Controls.MetroTabControl Documents;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Business_Permit;
        private System.Windows.Forms.Button Barangay_Franchise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}