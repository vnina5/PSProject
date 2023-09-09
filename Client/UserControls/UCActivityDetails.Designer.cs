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
            this.SuspendLayout();
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(446, 74);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(137, 22);
            this.txtPoints.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Points";
            // 
            // txtNameActivity
            // 
            this.txtNameActivity.Location = new System.Drawing.Point(128, 21);
            this.txtNameActivity.Name = "txtNameActivity";
            this.txtNameActivity.Size = new System.Drawing.Size(222, 22);
            this.txtNameActivity.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Activity name";
            // 
            // txtPlannedDuration
            // 
            this.txtPlannedDuration.Location = new System.Drawing.Point(150, 71);
            this.txtPlannedDuration.Name = "txtPlannedDuration";
            this.txtPlannedDuration.Size = new System.Drawing.Size(107, 22);
            this.txtPlannedDuration.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Planned duration";
            // 
            // txtActualDuration
            // 
            this.txtActualDuration.Location = new System.Drawing.Point(150, 118);
            this.txtActualDuration.Name = "txtActualDuration";
            this.txtActualDuration.Size = new System.Drawing.Size(107, 22);
            this.txtActualDuration.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Actual duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "h";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(446, 121);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(137, 22);
            this.txtStatus.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Status";
            // 
            // UCActivityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(653, 228);
            this.Load += new System.EventHandler(this.UCActivityDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtNameActivity;
        private System.Windows.Forms.TextBox txtPlannedDuration;
        private System.Windows.Forms.TextBox txtActualDuration;
        private System.Windows.Forms.TextBox txtStatus;

        public TextBox TxtPoints { get => txtPoints; set => txtPoints = value; }
        public TextBox TxtNameActivity { get => txtNameActivity; set => txtNameActivity = value; }
        public TextBox TxtPlannedDuration { get => txtPlannedDuration; set => txtPlannedDuration = value; }
        public TextBox TxtActualDuration { get => txtActualDuration; set => txtActualDuration = value; }
        public TextBox TxtStatus { get => txtStatus; set => txtStatus = value; }
    }
}
