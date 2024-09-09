using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace badix52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("\\\\192.168.3.250\\Veda\\3 курс\\ИСП 31-9\\МДК 03.02\\Алфёров Байков\\badix52\\badix52\\Без имени.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("\\\\192.168.3.250\\Veda\\3 курс\\ИСП 31-9\\МДК 03.02\\Алфёров Байков\\badix52\\badix52\\Без им52ени.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
