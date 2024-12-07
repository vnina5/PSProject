using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCActivityDetails
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
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameActivity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlannedDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActualDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMA = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.dgvAssignedMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(517, 112);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(137, 22);
            this.txtPoints.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Points";
            // 
            // txtNameActivity
            // 
            this.txtNameActivity.Location = new System.Drawing.Point(185, 62);
            this.txtNameActivity.Name = "txtNameActivity";
            this.txtNameActivity.Size = new System.Drawing.Size(469, 22);
            this.txtNameActivity.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Activity name";
            // 
            // txtPlannedDuration
            // 
            this.txtPlannedDuration.Location = new System.Drawing.Point(185, 112);
            this.txtPlannedDuration.Name = "txtPlannedDuration";
            this.txtPlannedDuration.Size = new System.Drawing.Size(107, 22);
            this.txtPlannedDuration.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Planned duration";
            // 
            // txtActualDuration
            // 
            this.txtActualDuration.Location = new System.Drawing.Point(185, 159);
            this.txtActualDuration.Name = "txtActualDuration";
            this.txtActualDuration.Size = new System.Drawing.Size(107, 22);
            this.txtActualDuration.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Actual duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "h";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(517, 159);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(137, 22);
            this.txtStatus.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "ACTIVITY DETAILS";
            // 
            // btnMA
            // 
            this.btnMA.Location = new System.Drawing.Point(516, 221);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(137, 30);
            this.btnMA.TabIndex = 75;
            this.btnMA.Text = "MA";
            this.btnMA.UseVisualStyleBackColor = true;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(58, 235);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(124, 16);
            this.lblMember.TabIndex = 77;
            this.lblMember.Text = "Assigned members";
            // 
            // dgvAssignedMembers
            // 
            this.dgvAssignedMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedMembers.Location = new System.Drawing.Point(61, 276);
            this.dgvAssignedMembers.Name = "dgvAssignedMembers";
            this.dgvAssignedMembers.RowHeadersWidth = 51;
            this.dgvAssignedMembers.RowTemplate.Height = 24;
            this.dgvAssignedMembers.Size = new System.Drawing.Size(592, 240);
            this.dgvAssignedMembers.TabIndex = 78;
            // 
            // UCActivityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAssignedMembers);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.btnMA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActualDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlannedDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameActivity);
            this.Controls.Add(this.label6);
            this.Name = "UCActivityDetails";
            this.Size = new System.Drawing.Size(750, 550);
            this.Load += new System.EventHandler(this.UCActivityDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label6;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label lblMember;
        private TextBox txtPoints;
        private TextBox txtNameActivity;
        private TextBox txtPlannedDuration;
        private TextBox txtActualDuration;
        private TextBox txtStatus;
        private Button btnMA;
        private DataGridView dgvAssignedMembers;

        public TextBox TxtPoints { get => txtPoints; set => txtPoints = value; }
        public TextBox TxtNameActivity { get => txtNameActivity; set => txtNameActivity = value; }
        public TextBox TxtPlannedDuration { get => txtPlannedDuration; set => txtPlannedDuration = value; }
        public TextBox TxtActualDuration { get => txtActualDuration; set => txtActualDuration = value; }
        public TextBox TxtStatus { get => txtStatus; set => txtStatus = value; }
        public Button BtnMA { get => btnMA; set => btnMA = value; }
        //public TextBox TxtMember { get => txtMember; set => txtMember = value; }
        public Label LblMember { get => lblMember; set => lblMember = value; }
        public DataGridView DgvAssignedMembers { get => dgvAssignedMembers; set => dgvAssignedMembers = value; }
    }
}
