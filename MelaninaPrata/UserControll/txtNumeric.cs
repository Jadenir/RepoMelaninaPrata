using System;
using System.Windows.Forms;
using MelaninaUtils;
using System.Globalization;

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
        //Leave
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                decimal valor = decimal.Parse(textBox1.Text.ToString());
                textBox1.Text = valor.ToString("N2", CultureInfo.CurrentCulture);
            }
            else
            {
                textBox1.Text = "0,00";
            }

        }
    }
}

