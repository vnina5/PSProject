using System.Windows.Forms;

namespace Client.Forms
{
    partial class FrmMembersAll
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
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtAdded = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(26, 68);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 50;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(762, 258);
            this.dgvMembers.TabIndex = 11;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(565, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(794, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Members";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(548, 443);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(240, 30);
            this.btnAssign.TabIndex = 76;
            this.btnAssign.Text = "Assign activity";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // txtAdded
            // 
            this.txtAdded.Location = new System.Drawing.Point(26, 352);
            this.txtAdded.Name = "txtAdded";
            this.txtAdded.Size = new System.Drawing.Size(762, 63);
            this.txtAdded.TabIndex = 77;
            this.txtAdded.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(794, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(794, 68);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(110, 30);
            this.btnViewAll.TabIndex = 79;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Last name:";
            // 
            // FrmMembersAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdded);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMembers);
            this.Name = "FrmMembersAll";
            this.Text = "FrmMembersAll";
            this.Load += new System.EventHandler(this.FrmMembersAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAssign;
        private DataGridView dgvMembers;
        private RichTextBox txtAdded;
        private Button btnAdd;
        private Button btnViewAll;
        private Label label2;

        public TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public Button BtnAssign { get => btnAssign; set => btnAssign = value; }
        public DataGridView DgvMembers { get => dgvMembers; set => dgvMembers = value; }
        public RichTextBox TxtAdded { get => txtAdded; set => txtAdded = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public Button BtnViewAll { get => btnViewAll; set => btnViewAll = value; }
    }
}