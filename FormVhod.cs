using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class FormVhod : Form
    {
        public FormVhod()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        public Пользователи USER { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string capcha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < 4; i++)
            {
                lCapcha.Text += capcha[rnd.Next(capcha.Length)];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lreg_Click(object sender, EventArgs e)
        {
            FormReg frm = new FormReg();
            this.Hide();
            frm.Show();
        }

        private void bvhod_Click(object sender, EventArgs e)
        {
            if (tlog.Text == "" || tpass.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            Пользователи usr = db.Пользователи.SingleOrDefault(m => m.Логин == tlog.Text);
            if ((usr != null) && (usr.Пароль == tpass.Text))
            {
                if (tCapcha.Text != lCapcha.Text)
                {
                    MessageBox.Show("Не верная капча");
                    return;
                }
               
                USER = usr;
                if (usr.IDРоли == 1)
                {
                    adminForm admin = new adminForm();
                    admin.Show();
                    this.Hide();
                }
                else if (usr.IDРоли == 2)
                {
                    SotrudnikForm parih = new SotrudnikForm();
                    parih.Show();
                    this.Hide();
                }
                else if (usr.IDРоли == 3)
                {
                    SotrudnikForm rest = new SotrudnikForm();
                    rest.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли{usr.IDРоли} в системе нет");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует");
                return;
            }
          
        }

        private void tCapcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
