using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace knigniMagazin.Forms
{
    public partial class Books : Form
    {
        public List<UserPanel> AllUserPanels = new List<UserPanel>();
        public List<UserPanel> FilteredPanels = new List<UserPanel>();
        public List<UserPanel> OrderUserList = new List<UserPanel>();
        public int NowPage = 0;
        public Books()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserPanel[] temp_AllUserPanels = AllUserPanels.ToArray();

            UserPanel tempUserPanel;
            for (int i = 0; i < temp_AllUserPanels.Length; i++)
            {
                for (int j = i + 1; j < temp_AllUserPanels.Length; j++)
                {
                    if (String.Compare(temp_AllUserPanels[i].getTitle(), temp_AllUserPanels[j].getTitle()) == 1)
                    {
                        tempUserPanel = temp_AllUserPanels[i];
                        temp_AllUserPanels[i] = temp_AllUserPanels[j];
                        temp_AllUserPanels[j] = tempUserPanel;
                    }
                }
            }

            if (SortComboBox.SelectedIndex == 1)
            {
                temp_AllUserPanels = temp_AllUserPanels.Reverse().ToArray();
            }

            MainFlow.Controls.Clear();
            foreach (UserPanel CurrentUserPanel in temp_AllUserPanels)
            {
                MainFlow.Controls.Add(CurrentUserPanel);
            }
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPanels(FiltrComboBox.SelectedIndex);
        }

        void FilterPanels(int index)
        {
            FilteredPanels.Clear();

            if (index == 0)
            {
                FilteredPanels = AllUserPanels.ToList();
            }
            else
            {
                string filter = FiltrComboBox.Items[index].ToString();

                foreach (UserPanel CurrentUserPanel in AllUserPanels)
                {
                    if (CurrentUserPanel.getManufacturer() == filter)
                    {
                        FilteredPanels.Add(CurrentUserPanel);
                    }
                }
            }
        }


        private void MainFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exzemDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.exzemDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exzemDataSet.Отчет". При необходимости она может быть перемещена или удалена.
            this.отчетTableAdapter.Fill(this.exzemDataSet.Отчет);

        }

        private void FiltrComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void SortComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Авторизация reg = new Авторизация();
            reg.Show();
            this.Close();
        }
    }
}
