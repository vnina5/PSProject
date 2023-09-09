using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCMemberView
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMember = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(156, 71);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(110, 30);
            this.btnDetails.TabIndex = 10;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(701, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(930, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(28, 120);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 50;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(1014, 200);
            this.dgvMembers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Members";
            // 
            // pnlMember
            // 
            this.pnlMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMember.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMember.Location = new System.Drawing.Point(28, 346);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(1014, 200);
            this.pnlMember.TabIndex = 13;
            // 
            // UCMemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMembers);
            this.Name = "UCMemberView";
            this.Size = new System.Drawing.Size(1071, 569);
            this.Load += new System.EventHandler(this.UCMemberView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label label1;
        private Panel pnlMember;

        public Button BtnUpdate { get => btnUpdate; set => btnUpdate = value; }
        public Button BtnDetails { get => btnDetails; set => btnDetails = value; }
        public TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public DataGridView DgvMembers { get => dgvMembers; set => dgvMembers = value; }
        public Panel PnlMember { get => pnlMember; set => pnlMember = value; }
    }
}
