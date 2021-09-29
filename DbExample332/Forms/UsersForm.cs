using DbExample332.Classes;
using DbExample332.Classes.Entiryes;
using MySql.Data.MySqlClient;
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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData() {
            dgvUsers.Rows.Clear();
            //Перебирем строки из БД
            foreach (User user in User.Select())
            {
                //Выводим значение поля UserLogin UserName - возвращаем номер строки
                int r = dgvUsers.Rows.Add(user.UserLogin, user.UserName);
                //Записываем пользователя в тег строки
                dgvUsers.Rows[r].Tag = user;
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        
    
        private void btAdd_Click(object sender, EventArgs e) { 
            //Показываем форму добавления нового пользователя
            new UsersAddForm(new User()).ShowDialog();
            //Обновляем имформацию в DGV
            UpdateData();
        }

        private void brEdit_Click(object sender, EventArgs e)
        {
            //Выбрана минимум одна строка
            if (dgvUsers.SelectedRows.Count > 0) 
            {
                //Достаем пользователя из тега строки и приводим к типу User
                User user = dgvUsers.SelectedRows[0].Tag as User;
                //Вызываем форму редактирования
                new UsersAddForm(user).ShowDialog();
                //Обновляем данные из БД
                UpdateData();

            }
        }
    }
}
