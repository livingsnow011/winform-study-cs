using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowForm.Chapter07_Form
{
    public partial class ButtonAndMessageBox : Form
    {
        public ButtonAndMessageBox()
        {
            InitializeComponent();
            currentTime = DateTime.Now;
        }

        DateTime currentTime;

        private void ButtonAndMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi\ncurrent time is " + currentTime.ToString());
        }
    }
}
