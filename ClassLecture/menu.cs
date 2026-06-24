using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClassLecture
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 足し算１を表示
            Addition1 addition1 = new Addition1();
            addition1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 足し算２を表示
            Addition2 addition2 = new Addition2();
            addition2.Show();
        }
    }
}
