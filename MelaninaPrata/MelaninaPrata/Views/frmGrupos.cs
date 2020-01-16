using System;
using MelaninaPrata.Controllers;
using MelaninaPrata.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MelaninaPrata.Views
{
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();
        }
        #region "Variaveis"

        #endregion
        #region "Eventos"
        //Load
        private void frmGrupos_Load(object sender, EventArgs e)
        {
            //LImpa todos os campos
            btnClear_Click(sender, e);
        }

        //Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            pPopulaGrupos();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe a descrição do grupo.");
                return;
            }
            grupos grupo = pMontaObjGrupo();
            GrupoController.SalvarGrupo(grupo);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string descricao = txtDescricao.Text;

            //Valida se foi informado um codigo
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um grupo.");
                return;
            }
            //Consulta grupo por ID
            grupos objGrupo = GrupoController.ListarGrupoPorID(codigo);
            //Valida se grupo existe
            if (objGrupo == null)
            {
                MessageBox.Show("O grupo não está cadastrado.");
                return;
            }
            //Exclui o grupo
            GrupoController.ExcluirGrupo(Convert.ToInt32(txtCodigo.Text.ToString()));
            MessageBox.Show("Grupo excluído com sucesso.");
        }

        //DoubleClick
        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Verifica se a linha selecionada e valida
                if (e.RowIndex < 0)
                {
                    return;
                }
                //Preenche os campos
                txtCodigo.Text = dgvGrupos.Rows[e.RowIndex].Cells[ColunaId.Index].Value.ToString();
                txtDescricao.Text = dgvGrupos.Rows[e.RowIndex].Cells[ColunaDescricao.Index].Value.ToString();
                txtDescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "Funções e Procedimentos"
        //Procedimentos
        private grupos pMontaObjGrupo()
        {
            grupos objGrupo = new grupos();
            objGrupo.descricao = txtDescricao.Text;
            return objGrupo;
        }
        private void pPopulaGrupos()
        {
            List<grupos> objGrupos = GrupoController.ListarTodosGrupos();
            DataGridViewRow dgvr;
            dgvGrupos.Rows.Clear();

            foreach (var item in objGrupos)
            {
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgvGrupos);
                dgvr.Cells[ColunaId.Index].Value = item.id;
                dgvr.Cells[ColunaDescricao.Index].Value = item.descricao;
                dgvGrupos.Rows.Add(dgvr);
            }
        }
        #endregion


    }
}
