using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MelaninaUtils;

namespace UserControll
{
    public partial class txtNumeric : UserControl
    {
        //Inicializa o componente
        public txtNumeric()
        {
            InitializeComponent();
        }
        //
        public string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        //keyPress
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Utils.IsNumeric(textBox1.Text))
            {
                textBox1.Clear();
            }
        }
    }
}

