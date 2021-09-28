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

            label1.Text = UserList.userList[0].firstName;
            label2.Text = UserList.userList[0].lastName;
            label3.Text = UserList.userList[0].alias;


        }
    }
}
