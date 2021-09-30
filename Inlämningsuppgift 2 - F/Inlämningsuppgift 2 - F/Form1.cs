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
            userList.loadUserList("Users");

            dgUsers.DataSource = userList.users;
            tbUsersByMonth.Text = userList.getBirthdaysString(userList.selectedMonth);
            lblMonth.Text = userList.selectedMonth.ToMonth();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userList.saveUserList("Users");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            userList.loadUserList("Users");
            dgUsers.DataSource = userList.users;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgUsers.Update();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userList.users.Add(new user());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            userList.users.RemoveAt(dgUsers.SelectedRows[0].Index);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            int currentUser = dgUsers.CurrentRow.Index;
            int age = userList.users[currentUser].CalculateAge();

            lblName.Text = userList.users[currentUser].firstName + " " + userList.users[currentUser].lastName + " is: ";

            if(age!=1)
            {
                lblYearsOld.Text = age.ToString() + " years old";
            }
            else
            {
                lblYearsOld.Text = age.ToString() + " year old";
            }

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            userList.selectedMonth++;
            tbUsersByMonth.Text = userList.getBirthdaysString(userList.selectedMonth);
            lblMonth.Text = userList.selectedMonth.ToMonth();
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            userList.selectedMonth--;
            tbUsersByMonth.Text = userList.getBirthdaysString(userList.selectedMonth);
            lblMonth.Text = userList.selectedMonth.ToMonth();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBlockedUsers.Text = "";
            tbGhostedUsers.Text = "";

            foreach (var user in userList.users)
            {
                if(user.isBlocked)
                    tbBlockedUsers.Text += user.firstName + " " + user.lastName + "\r\n";

                if(user.isGhosted)
                    tbGhostedUsers.Text += user.firstName + " " + user.lastName + "\r\n";
            }       
        }
    }
}
