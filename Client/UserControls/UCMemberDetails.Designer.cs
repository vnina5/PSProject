using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCMemberDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cmbYearOfStudy = new System.Windows.Forms.ComboBox();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year of study";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sector";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(208, 59);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(245, 22);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(208, 122);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(245, 22);
            this.txtLastname.TabIndex = 7;
            // 
            // cmbYearOfStudy
            // 
            this.cmbYearOfStudy.FormattingEnabled = true;
            this.cmbYearOfStudy.Location = new System.Drawing.Point(208, 262);
            this.cmbYearOfStudy.Name = "cmbYearOfStudy";
            this.cmbYearOfStudy.Size = new System.Drawing.Size(245, 24);
            this.cmbYearOfStudy.TabIndex = 9;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(208, 333);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(245, 24);
            this.cmbSector.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(343, 398);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 30);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(208, 192);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(245, 22);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // UCMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.cmbYearOfStudy);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCMemberDetails";
            this.Size = new System.Drawing.Size(573, 484);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ComboBox cmbYearOfStudy;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSave;

        public TextBox TxtFirstname { get => txtFirstname; set => txtFirstname = value; }
        public TextBox TxtLastname { get => txtLastname; set => txtLastname = value; }
        public ComboBox CmbYearOfStudy { get => cmbYearOfStudy; set => cmbYearOfStudy = value; }
        public ComboBox CmbSector { get => cmbSector; set => cmbSector = value; }
        public Button BtnCreate { get => btnCreate; set => btnCreate = value; }
        public DateTimePicker DtpDateOfBirth { get => dtpDateOfBirth; set => dtpDateOfBirth = value; }
        public Button BtnSave { get => btnSave; set => btnSave = value; }
    }
}
