using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_2___F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UserList.saveUserList("Users");

            UserList.loadUserList("Users");

            dgUsers.DataSource = UserList.userList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserList.saveUserList("Users");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            UserList.loadUserList("Users");
            dgUsers.DataSource = UserList.userList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //dgUsers.DataSource = UserList.userList;
            dgUsers.Update();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserList.userList.Add(new User());
            //dgUsers.DataSource = UserList.userList;

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserList.userList.RemoveAt(dgUsers.SelectedRows[0].Index);

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
