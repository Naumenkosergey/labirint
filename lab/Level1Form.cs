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
    public partial class Level1Form : Form
    {
        public Level1Form()
        {
            InitializeComponent();
        }

        private void Level1Form_Shown(object sender, EventArgs e)
        {
            StartLevel();
        }
        void StartLevel()
        {
            
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            cube = 0;
        }

        

        private void Restart()
        {
            DialogResult dr= MessageBox.Show("Вы Проиграли, может еще раз?", "GameOver", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                StartLevel();
            else
                DialogResult = DialogResult.Abort;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            Restart();
        }

        private void Labelfinish_MouseEnter(object sender, EventArgs e)
        {
            if (cube == 4)
                DialogResult = DialogResult.OK;
        }
        int cube = 0;
        private void Label6_Enter(object sender, EventArgs e)
        {
    
            
        }

        private void Label6_MouseEnter(object sender, EventArgs e)
        {
            Sound.PlayCkick();
            sender.GetType().GetProperty("Visible").SetValue(sender, false);
            cube++;
        }
    }
}
