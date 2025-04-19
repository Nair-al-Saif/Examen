using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaFarm
{
    public partial class FormLogin : Form
    {
       VitaFarmEntities1 DB = new VitaFarmEntities1();
        UsefulClasess UC = new UsefulClasess();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (TextLogin.Text.Count() == 0 || TextPassword.Text.Count() == 0)
            {
                UC.Message("Все поля должны быть заполнены!", "I!");
                return;
            }
            var Users = (from x in DB.Users
                         where x.Login == TextLogin.Text
                         select x).ToArray();
            if (TextLogin.Text != Users[0].Login)
            {
                UC.Message("Неправильный логин или пароль", "E!");
                return;
            }
            if (TextPassword.Text != Users[0].Password)
            {
                UC.Message("Неправильный логин или пароль", "E!");
                return;
            }
            FormMedList MedList = new FormMedList();
            switch (Users[0].Role)
            {
                case 1:
                    UC.Message("Система приветствует администратора!\nК сожалению, функционал администратора пока недоступен", "Info!");
                    break;
                case 2:
                    UC.Message("Добро пожаловать, " + Users[0].Family, "I!");
                    this.Hide();
                    MedList.Show();
                    break;
                case 3:
                    UC.Message("Добро пожаловать, " + Users[0].Name, "I");
                    this.Hide();
                    MedList.Show();
                    break;
            }

        }

        private void LabelRegistration_Click(object sender, EventArgs e)
        {
            UC.Message("Окно регистрации пока недоступно", "I");
        }

        private void LabelGuest_Click(object sender, EventArgs e)
        {
            UC.Message("Окно просмотра ассортимента пока недоступно", "I");
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
