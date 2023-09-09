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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(780, 471);
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
            this.dtpDateOfEnd.Location = new System.Drawing.Point(163, 253);
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
            this.label4.Location = new System.Drawing.Point(58, 258);
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
            this.dtpDateOfStart.Location = new System.Drawing.Point(163, 197);
            this.dtpDateOfStart.Name = "dtpDateOfStart";
            this.dtpDateOfStart.Size = new System.Drawing.Size(245, 22);
            this.dtpDateOfStart.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date of start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(163, 307);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.Size = new System.Drawing.Size(274, 142);
            this.dgvActivities.TabIndex = 20;
            // 
            // pnlActivity
            // 
            this.pnlActivity.Location = new System.Drawing.Point(490, 49);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(400, 400);
            this.pnlActivity.TabIndex = 41;
            this.pnlActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActivity_Paint);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(163, 471);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(110, 30);
            this.btnAddActivity.TabIndex = 42;
            this.btnAddActivity.Text = "Add activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Location = new System.Drawing.Point(327, 471);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(110, 30);
            this.btnDeleteActivity.TabIndex = 43;
            this.btnDeleteActivity.Text = "Delete activity";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 69);
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
            // FrmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.pnlActivity);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.label5);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDateOfEnd;
        private System.Windows.Forms.DateTimePicker dtpDateOfStart;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnDeleteActivity;
        private TextBox txtDescription;
        private Label label7;

        public TextBox TxtName { get => txtName; set => txtName = value; }
        public DateTimePicker DtpDateOfEnd { get => dtpDateOfEnd; set => dtpDateOfEnd = value; }
        public DateTimePicker DtpDateOfStart { get => dtpDateOfStart; set => dtpDateOfStart = value; }
        public DataGridView DgvActivities { get => dgvActivities; set => dgvActivities = value; }
        public Panel PnlActivity { get => pnlActivity; set => pnlActivity = value; }
        public Button BtnSave { get => btnSave; set => btnSave = value; }
        public Button BtnAddActivity { get => btnAddActivity; set => btnAddActivity = value; }
        public Button BtnDeleteActivity { get => btnDeleteActivity; set => btnDeleteActivity = value; }
        public TextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
    }
}