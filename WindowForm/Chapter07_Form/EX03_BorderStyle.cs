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
    public partial class BorderStyle : Form
    {
        public BorderStyle()
        {
            InitializeComponent();
        }
        private void BorderStyle_Load(object sender, EventArgs e)
        {
            setButtonText();    
        }

        private void setButtonText() {
            button1.Text =
                "Form.FormBorderStyle = " + FormBorderStyle.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //버튼 효과가 순환할 수 있도록
            if (FormBorderStyle == FormBorderStyle.SizableToolWindow)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle++;
            setButtonText();

        }

    }
}
