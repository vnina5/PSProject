using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCActivityAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameActivity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(145, 227);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(222, 22);
            this.txtDuration.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Duration (h)";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(145, 109);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(222, 89);
            this.txtDescription.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Description";
            // 
            // txtNameActivity
            // 
            this.txtNameActivity.Location = new System.Drawing.Point(145, 56);
            this.txtNameActivity.Name = "txtNameActivity";
            this.txtNameActivity.Size = new System.Drawing.Size(222, 22);
            this.txtNameActivity.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Activity";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(145, 278);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(222, 22);
            this.txtPoints.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Points";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(43, 338);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(110, 30);
            this.btnCancle.TabIndex = 58;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // UCActivityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNameActivity);
            this.Controls.Add(this.label6);
            this.Name = "UCActivityAdd";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UCActivityAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNameActivity;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;

        public TextBox TxtDuration { get => txtDuration; set => txtDuration = value; }
        public TextBox TxtDescription { get => txtDescription; set => txtDescription = value; }
        public TextBox TxtNameActivity { get => txtNameActivity; set => txtNameActivity = value; }
        public TextBox TxtPoints { get => txtPoints; set => txtPoints = value; }
        public Button BtnCancle { get => btnCancle; set => btnCancle = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
    }
}
