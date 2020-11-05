using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713139.Properties;

namespace WP_2020_01_HW02_3A713139
{
    public partial class frmGame : Form
    {
        
        List<Image> list = new List<Image>();
        public frmGame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = new Random().Next(3);//模擬隨機產生 一個值;
            picResult.Image = list[index];
            index++;
            richTextBox1.Text = "第:" + index +"張";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {   
            
        }

        
    }
}
