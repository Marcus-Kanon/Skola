
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpEditUsers = new System.Windows.Forms.TabPage();
            this.tpUserMonth = new System.Windows.Forms.TabPage();
            this.tpBlockedUsers = new System.Windows.Forms.TabPage();
            this.tpGhostedUsers = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYearsOld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.tabControl.SuspendLayout();
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
            this.dgUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.GridColor = System.Drawing.Color.Black;
            this.dgUsers.Location = new System.Drawing.Point(6, 57);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 29;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(1282, 497);
            this.dgUsers.TabIndex = 2;
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(118, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Maroon;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 45);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(230, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Maroon;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(1182, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 45);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.Location = new System.Drawing.Point(1027, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(149, 45);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpEditUsers);
            this.tabControl.Controls.Add(this.tpUserMonth);
            this.tabControl.Controls.Add(this.tpBlockedUsers);
            this.tabControl.Controls.Add(this.tpGhostedUsers);
            this.tabControl.Location = new System.Drawing.Point(12, 133);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1302, 593);
            this.tabControl.TabIndex = 4;
            // 
            // tpEditUsers
            // 
            this.tpEditUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(22, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Select a User";
            // 
            // lblYearsOld
            // 
            this.lblYearsOld.AutoSize = true;
            this.lblYearsOld.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYearsOld.Location = new System.Drawing.Point(22, 54);
            this.lblYearsOld.Name = "lblYearsOld";
            this.lblYearsOld.Size = new System.Drawing.Size(0, 20);
            this.lblYearsOld.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1322, 876);
            this.Controls.Add(this.lblYearsOld);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpEditUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpEditUsers;
        private System.Windows.Forms.TabPage tpUserMonth;
        private System.Windows.Forms.TabPage tpBlockedUsers;
        private System.Windows.Forms.TabPage tpGhostedUsers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYearsOld;
    }
}

