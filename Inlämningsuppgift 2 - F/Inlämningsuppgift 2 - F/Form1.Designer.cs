﻿
namespace Inlämningsuppgift_2___F
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tabControll = new System.Windows.Forms.TabControl();
            this.tpEditUsers = new System.Windows.Forms.TabPage();
            this.tpUserMonth = new System.Windows.Forms.TabPage();
            this.tpBlockedUsers = new System.Windows.Forms.TabPage();
            this.tpGhostedUsers = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.tabControll.SuspendLayout();
            this.tpEditUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(536, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(6, 57);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 29;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(1282, 497);
            this.dgUsers.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 45);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(230, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(1182, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 45);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(1070, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(106, 45);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabControll
            // 
            this.tabControll.Controls.Add(this.tpEditUsers);
            this.tabControll.Controls.Add(this.tpUserMonth);
            this.tabControll.Controls.Add(this.tpBlockedUsers);
            this.tabControll.Controls.Add(this.tpGhostedUsers);
            this.tabControll.Location = new System.Drawing.Point(12, 133);
            this.tabControll.Name = "tabControll";
            this.tabControll.SelectedIndex = 0;
            this.tabControll.Size = new System.Drawing.Size(1302, 593);
            this.tabControll.TabIndex = 4;
            // 
            // tpEditUsers
            // 
            this.tpEditUsers.Controls.Add(this.dgUsers);
            this.tpEditUsers.Controls.Add(this.btnDeleteUser);
            this.tpEditUsers.Controls.Add(this.btnSave);
            this.tpEditUsers.Controls.Add(this.btnAddUser);
            this.tpEditUsers.Controls.Add(this.btnLoad);
            this.tpEditUsers.Controls.Add(this.btnRefresh);
            this.tpEditUsers.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpEditUsers.Location = new System.Drawing.Point(4, 29);
            this.tpEditUsers.Name = "tpEditUsers";
            this.tpEditUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpEditUsers.TabIndex = 0;
            this.tpEditUsers.Text = "Edit Users";
            this.tpEditUsers.UseVisualStyleBackColor = true;
            this.tpEditUsers.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tpUserMonth
            // 
            this.tpUserMonth.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpUserMonth.Location = new System.Drawing.Point(4, 29);
            this.tpUserMonth.Name = "tpUserMonth";
            this.tpUserMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserMonth.Size = new System.Drawing.Size(1294, 560);
            this.tpUserMonth.TabIndex = 1;
            this.tpUserMonth.Text = "Find Users by Birthday Month";
            this.tpUserMonth.UseVisualStyleBackColor = true;
            // 
            // tpBlockedUsers
            // 
            this.tpBlockedUsers.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpBlockedUsers.Location = new System.Drawing.Point(4, 29);
            this.tpBlockedUsers.Name = "tpBlockedUsers";
            this.tpBlockedUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpBlockedUsers.TabIndex = 2;
            this.tpBlockedUsers.Text = "Blocked Users";
            this.tpBlockedUsers.UseVisualStyleBackColor = true;
            // 
            // tpGhostedUsers
            // 
            this.tpGhostedUsers.Location = new System.Drawing.Point(4, 29);
            this.tpGhostedUsers.Name = "tpGhostedUsers";
            this.tpGhostedUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpGhostedUsers.TabIndex = 3;
            this.tpGhostedUsers.Text = "Ghosted Users";
            this.tpGhostedUsers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 876);
            this.Controls.Add(this.tabControll);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.tabControll.ResumeLayout(false);
            this.tpEditUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabControl tabControll;
        private System.Windows.Forms.TabPage tpEditUsers;
        private System.Windows.Forms.TabPage tpUserMonth;
        private System.Windows.Forms.TabPage tpBlockedUsers;
        private System.Windows.Forms.TabPage tpGhostedUsers;
    }
}

