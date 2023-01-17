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
    public partial class LoadAndClosed : Form
    {
        public LoadAndClosed()
        {
            InitializeComponent();
        }

        private void LoadAndClosed_Load(object sender, EventArgs e)
        {
            MessageBox.Show("this form is loaded");
        }

        private void LoadAndClosed_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Do you want close?", "really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //여기서 e는 FormClosingEventArgs 즉 종료를 취소를 의미 , 종료 취소를 안하겠다 = 종료하겠다.
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
