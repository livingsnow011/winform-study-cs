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
    public partial class MoveResize : Form
    {
        public MoveResize()
        {
            InitializeComponent();
        }

        private void setButtonText() {
            button1.Text = 
                "Location = " + Location + "\n +" +
                "Left/Right/Width = " + Left + " , " + Right + " , " + Width + "\n" +
                "Top/Bottom/Height = " + Top + " , " + Bottom + " , " + Height + "\n" +
                "Size = " + Size + "\n" +
                "ClientSize = " + ClientSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MoveResize_Move(object sender, EventArgs e)
        {
            setButtonText();
        }

        private void MoveResize_Resize(object sender, EventArgs e)
        {
            setButtonText();
        }

        private void MoveResize_Load(object sender, EventArgs e)
        {
            setButtonText();
        }
    }
}
