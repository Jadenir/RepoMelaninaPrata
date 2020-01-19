using System;
using MelaninaPrata.Controllers;
using MelaninaPrata.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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

        //KeyPress
        private void frmGrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int KeyAsc = Strings.Asc(e.KeyChar);
                if (Strings.Asc(e.KeyChar) == 13)
                {
                    System.Windows.Forms.SendKeys.Send("{tab}");
                    KeyAsc = 0;
                }

                if (KeyAsc == 0)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == char.Parse("'"))
                {
                    e.Handled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Leave
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                //Busca grupo por id
                grupos objGrupo = GrupoController.BuscaGrupoPorID(codigo);
                //Valida se encontrou algum registro
                if (objGrupo == null)
                {
                    MessageBox.Show("Grupo não está cadastrado.");
                    txtCodigo.Focus();
                    return;
                }
                //Preenche campos
                txtDescricao.Text = objGrupo.descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            //Valida se foi informada descrição
            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe a descrição do grupo.");
                return;
            }
            //Mota objeto de grupo para salvar
            grupos grupo = pMontaObjGrupo();
            //Salva grupo
            GrupoController.SalvarGrupo(grupo);
            MessageBox.Show("Grupo gravado com sucesso.");
            //Limpa os campos
            btnClear_Click(sender, e);
            //Coloca o foco na descrição
            txtDescricao.Focus();
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
            grupos objGrupos = GrupoController.BuscaGrupoPorID(codigo);
            //Valida se grupo existe
            if (objGrupos == null)
            {
                MessageBox.Show("O grupo não está cadastrado.");
                return;
            }
            //Exclui o grupo
            GrupoController.ExcluirGrupo(Convert.ToInt32(txtCodigo.Text.ToString()));
            MessageBox.Show("Grupo excluído com sucesso.");
            //Repopula grid
            btnClear_Click(sender, e);
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
        private grupos pMontaObjGrupo()
        {
            grupos objGrupo = new grupos();
            objGrupo.descricao = txtDescricao.Text;
            return objGrupo;
        }
        private void pPopulaGrupos()
        {
            //Consulta todos os grupos
            List<grupos> objGrupos = GrupoController.ListarTodosGrupos();
            DataGridViewRow dgvr;
            dgvGrupos.Rows.Clear();
            //Percorre o objeto para preencher a grid
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
