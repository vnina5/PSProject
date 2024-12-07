using System.Windows.Forms;

namespace Client.Forms
{
    partial class FrmProjectAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfEnd = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOfStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNameActivity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Project";
            // 
            // dtpDateOfEnd
            // 
            this.dtpDateOfEnd.Location = new System.Drawing.Point(163, 251);
            this.dtpDateOfEnd.Name = "dtpDateOfEnd";
            this.dtpDateOfEnd.Size = new System.Drawing.Size(245, 22);
            this.dtpDateOfEnd.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of end";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // dtpDateOfStart
            // 
            this.dtpDateOfStart.Location = new System.Drawing.Point(163, 203);
            this.dtpDateOfStart.Name = "dtpDateOfStart";
            this.dtpDateOfStart.Size = new System.Drawing.Size(245, 22);
            this.dtpDateOfStart.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date of start";
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(36, 243);
            this.dgvActivities.MaximumSize = new System.Drawing.Size(0, 195);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.Size = new System.Drawing.Size(0, 195);
            this.dgvActivities.TabIndex = 20;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Location = new System.Drawing.Point(400, 464);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(110, 30);
            this.btnDeleteActivity.TabIndex = 43;
            this.btnDeleteActivity.Text = "Delete activity";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 96);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 72);
            this.txtDescription.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Description";
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.Location = new System.Drawing.Point(271, 464);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(110, 30);
            this.btnUpdateActivity.TabIndex = 55;
            this.btnUpdateActivity.Text = "Change activity";
            this.btnUpdateActivity.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.btnUpdateActivity);
            this.groupBox1.Controls.Add(this.txtPoints);
            this.groupBox1.Controls.Add(this.btnDeleteActivity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddActivity);
            this.groupBox1.Controls.Add(this.dgvActivities);
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNameActivity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(474, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 511);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activities";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(57, 191);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(110, 30);
            this.btnCancle.TabIndex = 67;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(159, 131);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(222, 22);
            this.txtPoints.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Points";
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(271, 191);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(110, 30);
            this.btnAddActivity.TabIndex = 59;
            this.btnAddActivity.Text = "Add activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(159, 80);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(222, 22);
            this.txtDuration.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Duration (h)";
            // 
            // txtNameActivity
            // 
            this.txtNameActivity.Location = new System.Drawing.Point(159, 27);
            this.txtNameActivity.Name = "txtNameActivity";
            this.txtNameActivity.Size = new System.Drawing.Size(222, 22);
            this.txtNameActivity.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Name";
            // 
            // FrmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateOfStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateOfEnd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmProjectAdd";
            this.Text = "FrmProjectDetails";
            this.Load += new System.EventHandler(this.FrmProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox txtName;
        private DateTimePicker dtpDateOfEnd;
        private DateTimePicker dtpDateOfStart;
        private DataGridView dgvActivities;
        private Button btnSave;
        private Button btnDeleteActivity;
        private TextBox txtDescription;
        private Button btnUpdateActivity;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private Label label10;
        private Button btnCancle;
        private TextBox txtPoints;
        private Button btnAddActivity;
        private TextBox txtDuration;
        private TextBox txtNameActivity;

        public TextBox TxtName { get => txtName; set => txtName = value; }
        public DateTimePicker DtpDateOfEnd { get => dtpDateOfEnd; set => dtpDateOfEnd = value; }
        public DateTimePicker DtpDateOfStart { get => dtpDateOfStart; set => dtpDateOfStart = value; }
        public DataGridView DgvActivities { get => dgvActivities; set => dgvActivities = value; }
        public Button BtnSave { get => btnSave; set => btnSave = value; }
        public Button BtnDeleteActivity { get => btnDeleteActivity; set => btnDeleteActivity = value; }
        public TextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
        public Button BtnUpdateActivity { get => btnUpdateActivity; set => btnUpdateActivity = value; }
        public Button BtnCancle { get => btnCancle; set => btnCancle = value; }
        public TextBox TxtPoints { get => txtPoints; set => txtPoints = value; }
        public Button BtnAddActivity { get => btnAddActivity; set => btnAddActivity = value; }
        public TextBox TxtDuration { get => txtDuration; set => txtDuration = value; }
        public TextBox TxtNameActivity { get => txtNameActivity; set => txtNameActivity = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
    }
}