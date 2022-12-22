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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Formsaveklient : Form
    {

        public Model1 database { get; set; }
        public Formsaveklient()
        {
            InitializeComponent();
        }

        private void Formsaveklient_Load(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tsname.Text == "" || tname.Text == "" ||
                tfname.Text == "" || tnumber.Text == "")
            {
                MessageBox.Show("Необходимо ввести все требуемые данные!");
                return;
            }

            Клиент klient = new Клиент();
            klient.Фамилия = tsname.Text;
            klient.Имя = tname.Text;
            klient.Отчество = tfname.Text;
            klient.НомерТелефона = tnumber.Text;
            database.Клиент.Add(klient);
            try
            {
                database.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
