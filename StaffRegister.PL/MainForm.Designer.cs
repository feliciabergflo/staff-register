using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StaffRegister.PL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpStaffMembers = new GroupBox();
            label1 = new Label();
            listStaffMembers = new ListBox();
            grpStaffManagement = new GroupBox();
            cmbStaffTitle = new ComboBox();
            lblStaffName = new Label();
            txtStaffName = new TextBox();
            lblStaffTitle = new Label();
            btnDeleteStaff = new Button();
            btnEditStaff = new Button();
            btnAddStaff = new Button();
            txtSearchName = new TextBox();
            grpCompetences = new GroupBox();
            label3 = new Label();
            listCompetences = new ListBox();
            grpCompManagement = new GroupBox();
            cmbCompetenceLevel = new ComboBox();
            lblCompName = new Label();
            txtCompetenceName = new TextBox();
            lblCompLevel = new Label();
            btnRemoveComp = new Button();
            btnEditComp = new Button();
            btnAddComp = new Button();
            lblTitle = new Label();
            bindingSource1 = new BindingSource(components);
            pnlAdvSearch = new Panel();
            btnAdvSearchCancel = new Button();
            btnAdvSearchApply = new Button();
            cmbAdvSearchLevel = new ComboBox();
            cmbAdvSearchTitle = new ComboBox();
            txtAdvSearchComp = new TextBox();
            txtAdvSearchName = new TextBox();
            lblAdvSearchLevel = new Label();
            lblAdvSearchName = new Label();
            lblAdvSearchTitle = new Label();
            lblAdvSearchComp = new Label();
            btnAdvSearch = new Button();
            btnResetSearch = new Button();
            grpStaffMembers.SuspendLayout();
            grpStaffManagement.SuspendLayout();
            grpCompetences.SuspendLayout();
            grpCompManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            pnlAdvSearch.SuspendLayout();
            SuspendLayout();
            // 
            // grpStaffMembers
            // 
            grpStaffMembers.Controls.Add(label1);
            grpStaffMembers.Controls.Add(listStaffMembers);
            grpStaffMembers.Controls.Add(grpStaffManagement);
            grpStaffMembers.Controls.Add(btnDeleteStaff);
            grpStaffMembers.Controls.Add(btnEditStaff);
            grpStaffMembers.Controls.Add(btnAddStaff);
            grpStaffMembers.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpStaffMembers.Location = new Point(12, 88);
            grpStaffMembers.Name = "grpStaffMembers";
            grpStaffMembers.Size = new Size(931, 237);
            grpStaffMembers.TabIndex = 0;
            grpStaffMembers.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(507, 28);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 9;
            label1.Text = "Staff Members";
            // 
            // listStaffMembers
            // 
            listStaffMembers.BorderStyle = BorderStyle.FixedSingle;
            listStaffMembers.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listStaffMembers.FormattingEnabled = true;
            listStaffMembers.ItemHeight = 21;
            listStaffMembers.Location = new Point(11, 27);
            listStaffMembers.Name = "listStaffMembers";
            listStaffMembers.Size = new Size(473, 191);
            listStaffMembers.TabIndex = 8;
            listStaffMembers.SelectedIndexChanged += listStaffMembers_SelectedIndexChanged;
            // 
            // grpStaffManagement
            // 
            grpStaffManagement.Controls.Add(cmbStaffTitle);
            grpStaffManagement.Controls.Add(lblStaffName);
            grpStaffManagement.Controls.Add(txtStaffName);
            grpStaffManagement.Controls.Add(lblStaffTitle);
            grpStaffManagement.Location = new Point(507, 49);
            grpStaffManagement.Name = "grpStaffManagement";
            grpStaffManagement.Size = new Size(399, 110);
            grpStaffManagement.TabIndex = 7;
            grpStaffManagement.TabStop = false;
            // 
            // cmbStaffTitle
            // 
            cmbStaffTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffTitle.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffTitle.FormattingEnabled = true;
            cmbStaffTitle.Location = new Point(155, 67);
            cmbStaffTitle.Name = "cmbStaffTitle";
            cmbStaffTitle.Size = new Size(225, 31);
            cmbStaffTitle.TabIndex = 9;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffName.Location = new Point(11, 27);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(97, 22);
            lblStaffName.TabIndex = 6;
            lblStaffName.Text = "Staff Name:";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(155, 25);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(225, 30);
            txtStaffName.TabIndex = 8;
            // 
            // lblStaffTitle
            // 
            lblStaffTitle.AutoSize = true;
            lblStaffTitle.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaffTitle.Location = new Point(11, 70);
            lblStaffTitle.Name = "lblStaffTitle";
            lblStaffTitle.Size = new Size(85, 22);
            lblStaffTitle.TabIndex = 7;
            lblStaffTitle.Text = "Staff Title:";
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = SystemColors.MenuHighlight;
            btnDeleteStaff.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteStaff.ForeColor = Color.White;
            btnDeleteStaff.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteStaff.Location = new Point(782, 181);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(126, 41);
            btnDeleteStaff.TabIndex = 3;
            btnDeleteStaff.Text = "Remove Staff";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnEditStaff
            // 
            btnEditStaff.BackColor = SystemColors.MenuHighlight;
            btnEditStaff.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditStaff.ForeColor = Color.White;
            btnEditStaff.ImageAlign = ContentAlignment.MiddleRight;
            btnEditStaff.Location = new Point(643, 181);
            btnEditStaff.Name = "btnEditStaff";
            btnEditStaff.Size = new Size(126, 41);
            btnEditStaff.TabIndex = 2;
            btnEditStaff.Text = "Edit Staff";
            btnEditStaff.UseVisualStyleBackColor = false;
            btnEditStaff.Click += btnEditStaff_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = SystemColors.MenuHighlight;
            btnAddStaff.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStaff.ForeColor = Color.White;
            btnAddStaff.ImageAlign = ContentAlignment.MiddleRight;
            btnAddStaff.Location = new Point(503, 181);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(126, 41);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.Text = "Add Staff";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Calibri Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearchName.Location = new Point(518, 12);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(246, 26);
            txtSearchName.TabIndex = 5;
            txtSearchName.Text = "Search name...";
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // grpCompetences
            // 
            grpCompetences.Controls.Add(label3);
            grpCompetences.Controls.Add(listCompetences);
            grpCompetences.Controls.Add(grpCompManagement);
            grpCompetences.Controls.Add(btnRemoveComp);
            grpCompetences.Controls.Add(btnEditComp);
            grpCompetences.Controls.Add(btnAddComp);
            grpCompetences.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpCompetences.Location = new Point(12, 331);
            grpCompetences.Name = "grpCompetences";
            grpCompetences.Size = new Size(931, 233);
            grpCompetences.TabIndex = 1;
            grpCompetences.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(507, 22);
            label3.Name = "label3";
            label3.Size = new Size(123, 24);
            label3.TabIndex = 10;
            label3.Text = "Competences";
            // 
            // listCompetences
            // 
            listCompetences.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listCompetences.FormattingEnabled = true;
            listCompetences.ItemHeight = 21;
            listCompetences.Location = new Point(11, 22);
            listCompetences.Name = "listCompetences";
            listCompetences.Size = new Size(473, 193);
            listCompetences.TabIndex = 9;
            // 
            // grpCompManagement
            // 
            grpCompManagement.Controls.Add(cmbCompetenceLevel);
            grpCompManagement.Controls.Add(lblCompName);
            grpCompManagement.Controls.Add(txtCompetenceName);
            grpCompManagement.Controls.Add(lblCompLevel);
            grpCompManagement.Location = new Point(507, 45);
            grpCompManagement.Name = "grpCompManagement";
            grpCompManagement.Size = new Size(399, 108);
            grpCompManagement.TabIndex = 10;
            grpCompManagement.TabStop = false;
            // 
            // cmbCompetenceLevel
            // 
            cmbCompetenceLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetenceLevel.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCompetenceLevel.FormattingEnabled = true;
            cmbCompetenceLevel.Location = new Point(155, 66);
            cmbCompetenceLevel.Name = "cmbCompetenceLevel";
            cmbCompetenceLevel.Size = new Size(225, 31);
            cmbCompetenceLevel.TabIndex = 9;
            // 
            // lblCompName
            // 
            lblCompName.AutoSize = true;
            lblCompName.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompName.Location = new Point(11, 26);
            lblCompName.Name = "lblCompName";
            lblCompName.Size = new Size(111, 22);
            lblCompName.TabIndex = 6;
            lblCompName.Text = "Comp. Name:";
            // 
            // txtCompetenceName
            // 
            txtCompetenceName.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompetenceName.Location = new Point(155, 24);
            txtCompetenceName.Name = "txtCompetenceName";
            txtCompetenceName.Size = new Size(225, 30);
            txtCompetenceName.TabIndex = 8;
            // 
            // lblCompLevel
            // 
            lblCompLevel.AutoSize = true;
            lblCompLevel.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompLevel.Location = new Point(11, 69);
            lblCompLevel.Name = "lblCompLevel";
            lblCompLevel.Size = new Size(105, 22);
            lblCompLevel.TabIndex = 7;
            lblCompLevel.Text = "Comp. Level:";
            // 
            // btnRemoveComp
            // 
            btnRemoveComp.BackColor = SystemColors.MenuHighlight;
            btnRemoveComp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveComp.ForeColor = Color.White;
            btnRemoveComp.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveComp.Location = new Point(780, 176);
            btnRemoveComp.Name = "btnRemoveComp";
            btnRemoveComp.Size = new Size(126, 41);
            btnRemoveComp.TabIndex = 6;
            btnRemoveComp.Text = "Remove Comp.";
            btnRemoveComp.UseVisualStyleBackColor = false;
            btnRemoveComp.Click += btnRemoveComp_Click;
            // 
            // btnEditComp
            // 
            btnEditComp.BackColor = SystemColors.MenuHighlight;
            btnEditComp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditComp.ForeColor = Color.White;
            btnEditComp.ImageAlign = ContentAlignment.MiddleRight;
            btnEditComp.Location = new Point(643, 176);
            btnEditComp.Name = "btnEditComp";
            btnEditComp.Size = new Size(126, 41);
            btnEditComp.TabIndex = 5;
            btnEditComp.Text = "Edit Comp.";
            btnEditComp.UseVisualStyleBackColor = false;
            btnEditComp.Click += btnEditComp_Click;
            // 
            // btnAddComp
            // 
            btnAddComp.BackColor = SystemColors.MenuHighlight;
            btnAddComp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddComp.ForeColor = Color.White;
            btnAddComp.ImageAlign = ContentAlignment.MiddleRight;
            btnAddComp.Location = new Point(503, 176);
            btnAddComp.Name = "btnAddComp";
            btnAddComp.Size = new Size(126, 41);
            btnAddComp.TabIndex = 4;
            btnAddComp.Text = "Add Comp.";
            btnAddComp.UseVisualStyleBackColor = false;
            btnAddComp.Click += btnAddComp_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(16, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(182, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Staff Register";
            // 
            // pnlAdvSearch
            // 
            pnlAdvSearch.BackColor = Color.White;
            pnlAdvSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlAdvSearch.Controls.Add(btnAdvSearchCancel);
            pnlAdvSearch.Controls.Add(btnAdvSearchApply);
            pnlAdvSearch.Controls.Add(cmbAdvSearchLevel);
            pnlAdvSearch.Controls.Add(cmbAdvSearchTitle);
            pnlAdvSearch.Controls.Add(txtAdvSearchComp);
            pnlAdvSearch.Controls.Add(txtAdvSearchName);
            pnlAdvSearch.Controls.Add(lblAdvSearchLevel);
            pnlAdvSearch.Controls.Add(lblAdvSearchName);
            pnlAdvSearch.Controls.Add(lblAdvSearchTitle);
            pnlAdvSearch.Controls.Add(lblAdvSearchComp);
            pnlAdvSearch.Location = new Point(519, 44);
            pnlAdvSearch.Name = "pnlAdvSearch";
            pnlAdvSearch.Size = new Size(431, 140);
            pnlAdvSearch.TabIndex = 3;
            pnlAdvSearch.Visible = false;
            // 
            // btnAdvSearchCancel
            // 
            btnAdvSearchCancel.BackColor = SystemColors.ControlLight;
            btnAdvSearchCancel.FlatStyle = FlatStyle.Flat;
            btnAdvSearchCancel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdvSearchCancel.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdvSearchCancel.Location = new Point(264, 98);
            btnAdvSearchCancel.Name = "btnAdvSearchCancel";
            btnAdvSearchCancel.Size = new Size(78, 27);
            btnAdvSearchCancel.TabIndex = 8;
            btnAdvSearchCancel.Text = "Cancel";
            btnAdvSearchCancel.UseVisualStyleBackColor = false;
            btnAdvSearchCancel.Click += btnAdvSearchCancel_Click;
            // 
            // btnAdvSearchApply
            // 
            btnAdvSearchApply.BackColor = SystemColors.Highlight;
            btnAdvSearchApply.FlatStyle = FlatStyle.Flat;
            btnAdvSearchApply.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdvSearchApply.ForeColor = Color.White;
            btnAdvSearchApply.Location = new Point(348, 98);
            btnAdvSearchApply.Name = "btnAdvSearchApply";
            btnAdvSearchApply.Size = new Size(78, 27);
            btnAdvSearchApply.TabIndex = 7;
            btnAdvSearchApply.Text = "Apply";
            btnAdvSearchApply.UseVisualStyleBackColor = false;
            btnAdvSearchApply.Click += btnAdvSearchApply_Click;
            // 
            // cmbAdvSearchLevel
            // 
            cmbAdvSearchLevel.BackColor = SystemColors.MenuBar;
            cmbAdvSearchLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdvSearchLevel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAdvSearchLevel.FormattingEnabled = true;
            cmbAdvSearchLevel.Location = new Point(274, 52);
            cmbAdvSearchLevel.Name = "cmbAdvSearchLevel";
            cmbAdvSearchLevel.Size = new Size(149, 26);
            cmbAdvSearchLevel.TabIndex = 12;
            // 
            // cmbAdvSearchTitle
            // 
            cmbAdvSearchTitle.BackColor = SystemColors.MenuBar;
            cmbAdvSearchTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdvSearchTitle.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAdvSearchTitle.FormattingEnabled = true;
            cmbAdvSearchTitle.Location = new Point(274, 14);
            cmbAdvSearchTitle.Name = "cmbAdvSearchTitle";
            cmbAdvSearchTitle.Size = new Size(149, 26);
            cmbAdvSearchTitle.TabIndex = 10;
            // 
            // txtAdvSearchComp
            // 
            txtAdvSearchComp.BackColor = Color.White;
            txtAdvSearchComp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdvSearchComp.Location = new Point(69, 52);
            txtAdvSearchComp.Name = "txtAdvSearchComp";
            txtAdvSearchComp.Size = new Size(131, 26);
            txtAdvSearchComp.TabIndex = 11;
            // 
            // txtAdvSearchName
            // 
            txtAdvSearchName.BackColor = Color.White;
            txtAdvSearchName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdvSearchName.Location = new Point(69, 16);
            txtAdvSearchName.Name = "txtAdvSearchName";
            txtAdvSearchName.Size = new Size(131, 26);
            txtAdvSearchName.TabIndex = 9;
            // 
            // lblAdvSearchLevel
            // 
            lblAdvSearchLevel.AutoSize = true;
            lblAdvSearchLevel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvSearchLevel.Location = new Point(223, 54);
            lblAdvSearchLevel.Name = "lblAdvSearchLevel";
            lblAdvSearchLevel.Size = new Size(45, 18);
            lblAdvSearchLevel.TabIndex = 10;
            lblAdvSearchLevel.Text = "Level:";
            // 
            // lblAdvSearchName
            // 
            lblAdvSearchName.AutoSize = true;
            lblAdvSearchName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvSearchName.Location = new Point(8, 21);
            lblAdvSearchName.Name = "lblAdvSearchName";
            lblAdvSearchName.Size = new Size(49, 18);
            lblAdvSearchName.TabIndex = 7;
            lblAdvSearchName.Text = "Name:";
            // 
            // lblAdvSearchTitle
            // 
            lblAdvSearchTitle.AutoSize = true;
            lblAdvSearchTitle.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvSearchTitle.Location = new Point(223, 21);
            lblAdvSearchTitle.Name = "lblAdvSearchTitle";
            lblAdvSearchTitle.Size = new Size(40, 18);
            lblAdvSearchTitle.TabIndex = 8;
            lblAdvSearchTitle.Text = "Title:";
            // 
            // lblAdvSearchComp
            // 
            lblAdvSearchComp.AutoSize = true;
            lblAdvSearchComp.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvSearchComp.Location = new Point(8, 54);
            lblAdvSearchComp.Name = "lblAdvSearchComp";
            lblAdvSearchComp.Size = new Size(52, 18);
            lblAdvSearchComp.TabIndex = 9;
            lblAdvSearchComp.Text = "Comp.:";
            // 
            // btnAdvSearch
            // 
            btnAdvSearch.BackColor = SystemColors.Highlight;
            btnAdvSearch.FlatStyle = FlatStyle.Flat;
            btnAdvSearch.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdvSearch.ForeColor = Color.White;
            btnAdvSearch.Location = new Point(770, 12);
            btnAdvSearch.Name = "btnAdvSearch";
            btnAdvSearch.Size = new Size(150, 27);
            btnAdvSearch.TabIndex = 6;
            btnAdvSearch.Text = "Advanced Search";
            btnAdvSearch.UseVisualStyleBackColor = false;
            btnAdvSearch.Click += btnAdvSearch_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.BackColor = SystemColors.ScrollBar;
            btnResetSearch.Enabled = false;
            btnResetSearch.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetSearch.ForeColor = Color.Black;
            btnResetSearch.Location = new Point(921, 11);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(29, 29);
            btnResetSearch.TabIndex = 9;
            btnResetSearch.Text = "X";
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 588);
            Controls.Add(btnResetSearch);
            Controls.Add(btnAdvSearch);
            Controls.Add(txtSearchName);
            Controls.Add(pnlAdvSearch);
            Controls.Add(lblTitle);
            Controls.Add(grpCompetences);
            Controls.Add(grpStaffMembers);
            Name = "MainForm";
            Text = "MainForm";
            grpStaffMembers.ResumeLayout(false);
            grpStaffMembers.PerformLayout();
            grpStaffManagement.ResumeLayout(false);
            grpStaffManagement.PerformLayout();
            grpCompetences.ResumeLayout(false);
            grpCompetences.PerformLayout();
            grpCompManagement.ResumeLayout(false);
            grpCompManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            pnlAdvSearch.ResumeLayout(false);
            pnlAdvSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpStaffMembers;
        private GroupBox grpCompetences;
        private Label lblTitle;
        private Button btnDeleteStaff;
        private Button btnEditStaff;
        private Button btnAddStaff;
        private Button btnRemoveComp;
        private Button btnEditComp;
        private Button btnAddComp;
        private TextBox txtSearchName;
        private Label lblStaffTitle;
        private Label lblStaffName;
        private ComboBox cmbStaffTitle;
        private TextBox txtStaffName;
        private GroupBox grpStaffManagement;
        private BindingSource bindingSource1;
        private GroupBox grpCompManagement;
        private ComboBox cmbCompetenceLevel;
        private Label lblCompName;
        private TextBox txtCompetenceName;
        private Label lblCompLevel;
        private ListBox listStaffMembers;
        private ListBox listCompetences;
        private Panel pnlAdvSearch;
        private Label lblAdvSearchName;
        private Label lblAdvSearchTitle;
        private Label lblAdvSearchComp;
        private Label lblAdvSearchLevel;
        private TextBox txtAdvSearchComp;
        private TextBox txtAdvSearchName;
        private ComboBox cmbAdvSearchTitle;
        private ComboBox cmbAdvSearchLevel;
        private Button btnAdvSearch;
        private Button btnAdvSearchApply;
        private Button btnAdvSearchCancel;
        private Label label1;
        private Label label3;
        private Button btnResetSearch;
    }
}