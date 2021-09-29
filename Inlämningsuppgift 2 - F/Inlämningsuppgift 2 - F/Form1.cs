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

            userList.loadUserList("Users");

            dgUsers.DataSource = userList.users;

            lblUsersByMonth.Text = getBirthdayUsers();
            lblMonth.Text = getSelectedMonth();

            displayBlockedUsers();
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
            var age = DateTime.Today.Year - userList.users[currentUser].birthday.Year;

            if (userList.users[currentUser].birthday.Date > DateTime.Today.AddYears(-age)) age--;

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

            lblUsersByMonth.Text = getBirthdayUsers();
            lblMonth.Text = getSelectedMonth();
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            userList.selectedMonth--;

            lblUsersByMonth.Text = getBirthdayUsers();
            lblMonth.Text = getSelectedMonth();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayBlockedUsers();
            displayGhostedUsers();
        }


        //***************************************************
        //Temp methods
        public void displayBlockedUsers()
        {
            tbBlockedUsers.Text = "";

            foreach (var user in userList.users.Where(q => q.isBlocked).ToList())
            {
                tbBlockedUsers.Text += user.firstName + " " + user.lastName + "\r\n";
            }
        }

        public void displayGhostedUsers()
        {
            tbGhostedUsers.Text = "";

            foreach (var user in userList.users.Where(q => q.isGhosted).ToList())
            {
                tbGhostedUsers.Text += user.firstName + " " + user.lastName + "\r\n";
            }
        }

        public string getSelectedMonth()
        {
            Enum.TryParse(typeof(months), userList.selectedMonth.ToString(), out object str);
            return str.ToString();
        }

        public string getBirthdayUsers()
        {
            IEnumerable<user> users = userList.filterUsersByMonthBorn();
            string str="";

            foreach (var user in users)
            {
                str += user.firstName + " " + user.lastName + "\n";
            }

            return str;
        }
    }
}
