using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knigniMagazin.Forms
{
    public partial class otch : Form
    {
        public otch()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void otch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exzemDataSet.Отчет". При необходимости она может быть перемещена или удалена.
            this.отчетTableAdapter.Fill(this.exzemDataSet.Отчет);

        }
    }
}
