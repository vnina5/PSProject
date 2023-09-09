using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCProjectView
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(703, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 22);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(932, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvProjects
            // 
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(30, 120);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 51;
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(1014, 197);
            this.dgvProjects.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Projects";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name:";
            // 
            // panel1
            // 
            this.pnlProject.Location = new System.Drawing.Point(33, 345);
            this.pnlProject.Name = "panel1";
            this.pnlProject.Size = new System.Drawing.Size(1009, 210);
            this.pnlProject.TabIndex = 23;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(285, 68);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(110, 30);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // UCProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProjects);
            this.Name = "UCProjectView";
            this.Size = new System.Drawing.Size(1074, 591);
            this.Load += new System.EventHandler(this.UCProjectView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private Button btnDetails;
        private System.Windows.Forms.DataGridView dgvProjects;
        private Panel pnlProject;

        public TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public Button BtnUpdate { get => btnUpdate; set => btnUpdate = value; }
        public Button BtnDetails { get => btnDetails; set => btnDetails = value; }
        public DataGridView DgvProjects { get => dgvProjects; set => dgvProjects = value; }
        public Panel PnlProject { get => pnlProject; set => pnlProject = value; }
    }
}
