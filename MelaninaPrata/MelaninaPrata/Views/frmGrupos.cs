using MelaninaModels;
using MelaninaControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace MelaninaPrata.Views
{
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            dgvGrupos.DataSource = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe a descrição do grupo.");
                return;
            }
            Grupo grupo = SalvarGrupos();
            GrupoController.SalvarGrupo(grupo);
        }

        private Grupo SalvarGrupos()
        {
            Grupo objGrupo = new Grupo();
            objGrupo.Descricao = txtDescricao.Text;
            return objGrupo;
        }
    }
}
