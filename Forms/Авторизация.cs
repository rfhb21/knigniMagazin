using knigniMagazin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knigniMagazin
{
    public partial class Авторизация : Form
    {

        public Авторизация()
        {
            InitializeComponent();
            LoadCapchaImage();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
        int number = 0;
        private void LoadCapchaImage()
        {
            Random num = new Random();
            number = num.Next(100, 10000);
            var image = new Bitmap(this.CapchaGen.Width, this.CapchaGen.Height);
            var font = new Font("TimesNewRoman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            var graf = Graphics.FromImage(image);
            graf.DrawString(number.ToString(), font, Brushes.Green, new Point(0, 0));
            CapchaGen.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadCapchaImage();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Capcha.Text == number.ToString())
            {
                MessageBox.Show("Капча введена верно");
            }
            else
            {
                MessageBox.Show("Капча введена неверно");
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            if (textBox1.Text == "123" && textBox2.Text == "123")
            {
                Books book = new Books();
                book.Show();
                this.Hide();
            }
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                otch otch = new otch();
                otch.Show();
                this.Hide();
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
