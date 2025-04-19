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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (TextLogin.Text.Count() > 0)
            {
                if (TextPassword.Text.Count() > 0)
                {
                    for (int i = 0; i < DB.Users.Count())
                }
            }
        }

        private void LabelRegistration_Click(object sender, EventArgs e)
        {

        }

        private void LabelGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
