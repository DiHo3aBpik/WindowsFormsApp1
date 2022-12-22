using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        private void bvhod_Click(object sender, EventArgs e)
        {
            if (tlog.Text == "" || tpass.Text == "" || trol.Text == null)
            {
                MessageBox.Show("Нужно заполнить все данные");
                return;
            }
            Пользователи usr = db.Пользователи.SingleOrDefault(m => m.Логин == tlog.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином существует");
                return;
            }
            usr = new Пользователи();
            usr.Логин = tlog.Text;
            usr.Пароль = tpass.Text;
            usr.IDРоли = Convert.ToInt32(trol.Text);
            db.Пользователи.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь" + usr.Логин + "Зарегистрирован");
            FormVhod auth = new FormVhod();
            this.Close();
            return;
        }

        private void tlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void trol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
