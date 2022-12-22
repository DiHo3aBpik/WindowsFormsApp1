using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formklient : Form
    {
        public Formklient()
        {
            InitializeComponent();
        }

        private void Formklient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.salonKrasotiDataSet.Клиент);

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            Formsaveklient frm = new Formsaveklient();
            frm.Show();
        }

        private void bback_Click(object sender, EventArgs e)
        {
            adminForm frm = new adminForm();
            this.Close();
            frm.Show();
        }
    }
}
