using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sound.PlayCkick();
            level1Start();
        }

        private void level1Start()
        {
            Level1Form level1 = new Level1Form();
            DialogResult dr =level1.ShowDialog();
            if (dr == DialogResult.OK)
                level2Start();
        }

        private void level2Start()
        {
            MessageBox.Show("Вы перешли на второй уровень");
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text = "Звук Есть";
                Sound.SoundON();
            }
            else
            {
                checkBox1.Text = "Звука Нет";
                Sound.SoundOff();
            }
        }
    }
}
