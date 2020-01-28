using MelaninaPrata.Controllers;
using MelaninaPrata.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MelaninaPrata.Views
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }
        #region "botões"
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtReferencia.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "0,00";
            txtCusto.Text = "0,00";
            pPopulaProdutos();
            //Consulta todos os grupos
            cmbGrupo.DataSource = GrupoController.ListarTodosGrupos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            produto objProduto = null;
            int codigo = 0;
            //Valida se foi informada a referencia do produto
            if (txtReferencia.Text.Equals(string.Empty))
            {
                MessageBox.Show("Informe a referencia do produto.");
                return;
            }
            //Valida se foi informada descrição
            if (txtDescricao.Text.Equals(string.Empty))
            {
                MessageBox.Show("Informe a descrição do produto.");
                return;
            }
            if (txtValor.Text.Equals(string.Empty))
            {
                MessageBox.Show("Informe o valor do produto.");
                return;
            }
            if (txtValor.Text.Equals(string.Empty))
            {
                MessageBox.Show("Informe o custo do produto");
                return;
            }
            if (txtCodigo.Text != string.Empty)
            {
                //Passa o codigo para uma variavel
                codigo = int.Parse(txtCodigo.Text);
                //Consulta grupo pelo id
                objProduto = ProdutoController.BuscaProdutoPorID(codigo);
            }
            //Se grupo não existir ele grava
            if (objProduto == null)
            {
                //Mota objeto de grupo para salvar
                produto produto = pMontaObjProduto();
                //Salva grupo
                ProdutoController.SalvarProduto(produto);
                //Mostra mensagem para o usuario
                MessageBox.Show("Produto gravado com sucesso.");
            }
            else
            {
                //Mota objeto de grupo para salvar
                produto produto = pMontaObjProduto();
                //Altera produto
                ProdutoController.AlterarProduto(codigo, produto);
                //Mostra mensagem para o usuario
                MessageBox.Show("Produto alterado com sucesso.");
            }
            //Limpa os campos
            btnClear_Click(sender, e);
            //Coloca o foco na referencia
            txtReferencia.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Valida se foi informado um codigo
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um grupo.");
                return;
            }
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string descricao = txtDescricao.Text;
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
        #endregion
        #region "formulário"
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            //LImpa todos os campos
            btnClear_Click(sender, e);
        }
        #endregion
        #region "datagridview"
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Verifica se a linha selecionada e valida
                if (e.RowIndex < 0)
                {
                    return;
                }
                //Preenche os campos
                txtCodigo.Text = dgvProdutos.Rows[e.RowIndex].Cells[colunaId.Index].Value.ToString();
                txtReferencia.Text = dgvProdutos.Rows[e.RowIndex].Cells[ColunaReferencia.Index].Value.ToString();
                txtDescricao.Text = dgvProdutos.Rows[e.RowIndex].Cells[colunaDescricao.Index].Value.ToString();
                cmbGrupo.SelectedValue = dgvProdutos.Rows[e.RowIndex].Cells[colunaCodGrupo.Index].Value;
                txtValor.Text = dgvProdutos.Rows[e.RowIndex].Cells[colunaValor.Index].Value.ToString();
                txtCusto.Text = dgvProdutos.Rows[e.RowIndex].Cells[colunaCusto.Index].Value.ToString();
                txtDescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "funções e procedimentos"
        private produto pMontaObjProduto()
        {
            produto objProduto = new produto();
            objProduto.id = int.Parse(txtCodigo.Text);
            objProduto.referencia = txtReferencia.Text;
            objProduto.descricao = txtDescricao.Text;
            objProduto.grupoId = int.Parse(cmbGrupo.SelectedValue.ToString());
            objProduto.grupos = GrupoController.BuscaGrupoPorID(int.Parse(objProduto.grupoId.ToString()));
            objProduto.valor = decimal.Parse(txtValor.Text);
            objProduto.custo = decimal.Parse(txtCusto.Text);
            return objProduto;
        }
        private void pPopulaProdutos()
        {
            //Consulta todos os produtos
            List<produto> objProdutos = ProdutoController.ListarTodosProdutos();
            DataGridViewRow dgvr;
            dgvProdutos.Rows.Clear();
            //Percorre o objeto para preencher a grid
            foreach (var item in objProdutos)
            {
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgvProdutos);
                dgvr.Cells[colunaId.Index].Value = item.id;
                dgvr.Cells[ColunaReferencia.Index].Value = item.referencia;
                dgvr.Cells[colunaDescricao.Index].Value = item.descricao;
                dgvr.Cells[colunaCodGrupo.Index].Value = item.grupoId;
                dgvr.Cells[colunaDescGrupo.Index].Value = item.grupos.descricao;
                dgvr.Cells[colunaValor.Index].Value = item.valor;
                dgvr.Cells[colunaCusto.Index].Value = item.custo;
                dgvProdutos.Rows.Add(dgvr);
            }
        }
        #endregion
    }
}
