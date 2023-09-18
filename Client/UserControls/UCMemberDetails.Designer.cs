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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtYearOfStudy = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoursOfWork = new System.Windows.Forms.TextBox();
            this.txtNumOfActivities = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnViewActivities = new System.Windows.Forms.Button();
            this.dgvMemberActivities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(231, 135);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(245, 22);
            this.txtLastname.TabIndex = 35;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(231, 79);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(245, 22);
            this.txtFirstname.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Year of study";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "First name";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(231, 324);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(245, 22);
            this.txtSector.TabIndex = 40;
            // 
            // txtYearOfStudy
            // 
            this.txtYearOfStudy.Location = new System.Drawing.Point(231, 260);
            this.txtYearOfStudy.Name = "txtYearOfStudy";
            this.txtYearOfStudy.Size = new System.Drawing.Size(245, 22);
            this.txtYearOfStudy.TabIndex = 41;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(700, 196);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(245, 22);
            this.txtPoints.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Points";
            // 
            // txtHoursOfWork
            // 
            this.txtHoursOfWork.Location = new System.Drawing.Point(700, 135);
            this.txtHoursOfWork.Name = "txtHoursOfWork";
            this.txtHoursOfWork.Size = new System.Drawing.Size(245, 22);
            this.txtHoursOfWork.TabIndex = 45;
            // 
            // txtNumOfActivities
            // 
            this.txtNumOfActivities.Location = new System.Drawing.Point(700, 79);
            this.txtNumOfActivities.Name = "txtNumOfActivities";
            this.txtNumOfActivities.Size = new System.Drawing.Size(245, 22);
            this.txtNumOfActivities.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Hours of work";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Number of activities";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "MEMBER DETAILS";
            // 
            // btnViewActivities
            // 
            this.btnViewActivities.Location = new System.Drawing.Point(835, 256);
            this.btnViewActivities.Name = "btnViewActivities";
            this.btnViewActivities.Size = new System.Drawing.Size(110, 30);
            this.btnViewActivities.TabIndex = 72;
            this.btnViewActivities.Text = "View activities";
            this.btnViewActivities.UseVisualStyleBackColor = true;
            // 
            // dgvMemberActivities
            // 
            this.dgvMemberActivities.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMemberActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberActivities.Location = new System.Drawing.Point(1007, 79);
            this.dgvMemberActivities.Name = "dgvMemberActivities";
            this.dgvMemberActivities.RowHeadersWidth = 51;
            this.dgvMemberActivities.RowTemplate.Height = 24;
            this.dgvMemberActivities.Size = new System.Drawing.Size(340, 207);
            this.dgvMemberActivities.TabIndex = 73;
            // 
            // UCMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMemberActivities);
            this.Controls.Add(this.btnViewActivities);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHoursOfWork);
            this.Controls.Add(this.txtNumOfActivities);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYearOfStudy);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCMemberDetails";
            this.Size = new System.Drawing.Size(1369, 413);
            this.Load += new System.EventHandler(this.UCMemberDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtEmail;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private TextBox txtSector;
        private TextBox txtYearOfStudy;
        private TextBox txtPoints;
        private TextBox txtHoursOfWork;
        private TextBox txtNumOfActivities;
        private Button btnViewActivities;
        private DataGridView dgvMemberActivities;

        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtLastname { get => txtLastname; set => txtLastname = value; }
        public TextBox TxtFirstname { get => txtFirstname; set => txtFirstname = value; }
        public TextBox TxtSector { get => txtSector; set => txtSector = value; }
        public TextBox TxtYearOfStudy { get => txtYearOfStudy; set => txtYearOfStudy = value; }
        public TextBox TxtPoints { get => txtPoints; set => txtPoints = value; }
        public TextBox TxtHoursOfWork { get => txtHoursOfWork; set => txtHoursOfWork = value; }
        public TextBox TxtNumOfActivities { get => txtNumOfActivities; set => txtNumOfActivities = value; }
        public Button BtnViewActivities { get => btnViewActivities; set => btnViewActivities = value; }
        public DataGridView DgvMemberActivities { get => dgvMemberActivities; set => dgvMemberActivities = value; }
    }
}
