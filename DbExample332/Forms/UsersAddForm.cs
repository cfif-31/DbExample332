using DbExample332.Classes.Entiryes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbExample332.Forms
{
    public partial class UsersAddForm : Form
    {
        User EditedUser;
        public UsersAddForm(User user)
        {
            this.EditedUser = user;
            InitializeComponent();

            tbLogin.Text = user.UserLogin;
            tbName.Text = user.UserName;
            tbPass.Text = user.UserPass;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Если мы добавляем пользователя
            if (EditedUser.UserId == 0)
                //Отпаравляем данные в метод добавления пользователя (добавляем пользователя в БД)
                User.Add(tbName.Text, tbLogin.Text, tbPass.Text);

            else
                EditedUser.Change(tbName.Text, tbLogin.Text, tbPass.Text);
        }
    }
}
