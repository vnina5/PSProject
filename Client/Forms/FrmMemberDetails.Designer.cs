using System.Windows.Forms;

namespace Client.Forms
{
    partial class FrmMemberAdd
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.cmbYearOfStudy = new System.Windows.Forms.ComboBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(270, 337);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(245, 24);
            this.cmbSector.TabIndex = 23;
            // 
            // cmbYearOfStudy
            // 
            this.cmbYearOfStudy.FormattingEnabled = true;
            this.cmbYearOfStudy.Location = new System.Drawing.Point(270, 266);
            this.cmbYearOfStudy.Name = "cmbYearOfStudy";
            this.cmbYearOfStudy.Size = new System.Drawing.Size(245, 24);
            this.cmbYearOfStudy.TabIndex = 22;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(270, 126);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(245, 22);
            this.txtLastname.TabIndex = 21;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(270, 63);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(245, 22);
            this.txtFirstname.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Year of study";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Member";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            // 
            // FrmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 486);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.cmbYearOfStudy);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMemberDetails";
            this.Text = "FrmMemberDetails";
            this.Load += new System.EventHandler(this.FrmMemberDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnSave;
        private ComboBox cmbSector;
        private ComboBox cmbYearOfStudy;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private TextBox txtEmail;

        public Button BtnSave { get => btnSave; set => btnSave = value; }
        //public DateTimePicker DtpDateOfBirth { get => dtpDateOfBirth; set => dtpDateOfBirth = value; }
        public ComboBox CmbSector { get => cmbSector; set => cmbSector = value; }
        public ComboBox CmbYearOfStudy { get => cmbYearOfStudy; set => cmbYearOfStudy = value; }
        public TextBox TxtLastname { get => txtLastname; set => txtLastname = value; }
        public TextBox TxtFirstname { get => txtFirstname; set => txtFirstname = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
    }
}