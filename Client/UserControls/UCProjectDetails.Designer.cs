using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCProjectDetails
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateEnd = new System.Windows.Forms.TextBox();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.pnlActivity = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(139, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 69);
            this.txtDescription.TabIndex = 58;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "End";
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(882, 23);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(245, 22);
            this.txtDateEnd.TabIndex = 61;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(526, 26);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(245, 22);
            this.txtDateStart.TabIndex = 62;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(526, 69);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(79, 22);
            this.txtDuration.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "All activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(29, 198);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.Size = new System.Drawing.Size(355, 195);
            this.dgvActivities.TabIndex = 67;
            // 
            // pnlActivity
            // 
            this.pnlActivity.Location = new System.Drawing.Point(474, 165);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(653, 228);
            this.pnlActivity.TabIndex = 68;
            // 
            // UCProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlActivity);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCProjectDetails";
            this.Size = new System.Drawing.Size(1150, 424);
            this.Load += new System.EventHandler(this.UCProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDateEnd;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Panel pnlActivity;

        public TextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtDateEnd { get => txtDateEnd; set => txtDateEnd = value; }
        public TextBox TxtDateStart { get => txtDateStart; set => txtDateStart = value; }
        public TextBox TxtDuration { get => txtDuration; set => txtDuration = value; }
        public DataGridView DgvActivities { get => dgvActivities; set => dgvActivities = value; }
        public Panel PnlActivity { get => pnlActivity; set => pnlActivity = value; }
    }
}
