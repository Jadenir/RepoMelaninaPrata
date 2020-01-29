using MelaninaPrata.Controllers;
using MelaninaPrata.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MelaninaPrata.Views
{
    public partial class frmPessoas : Form
    {
        public frmPessoas()
        {
            InitializeComponent();
        }
        #region "Variaveis"

        #endregion
        #region "Eventos"
        //Load
        private void frmPessoas_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }

        //KeyPress
        private void frmPessoas_KeyPress(object sender, KeyPressEventArgs e)
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

        //SelectedIndexChanged
        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            pPopulaComboCidade();
        }

        //Leave
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                //Valida se foi informado algum codigo
                if (txtCodigo.Text == "" || txtCodigo.Text == null)
                {
                    return;
                }
                //Busca pessoa por id
                pessoa objPessoa = PessoaController.BuscaPessoaPorID(Convert.ToInt32(txtCodigo.Text));
                //Valida se encontrou algum registro
                if (objPessoa == null)
                {
                    MessageBox.Show("Vendedor(a) não está cadastrado.");
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                    return;
                }
                //Preenche campos
                mskCpf.Text = objPessoa.cpf;
                dtpNascimento.Text = objPessoa.nascimento.ToString();
                txtNome.Text = objPessoa.nome;
                txtEndereco.Text = objPessoa.endereco;
                txtComplemento.Text = objPessoa.complemento;
                txtBairro.Text = objPessoa.bairro;
                txtNr.Text = objPessoa.numEndereco;
                mskCep.Text = objPessoa.cep;
                cmbUf.SelectedValue = objPessoa.uf;
                cmbCidade.SelectedValue = int.Parse(objPessoa.codigoCidade.ToString());
                mskTelefone.Text = objPessoa.telefone;
                txtComissao.Text = objPessoa.comissao.ToString();
                txtReferencia.Text = objPessoa.nomeReferencia.ToString();
                mskTelefoneReferencia.Text = objPessoa.telefoneReferencia;
                rtbObservacao.Text = objPessoa.observacao;
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
            mskCpf.Text = "";
            dtpNascimento.Value = DateTime.Now.Date;
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtNr.Text = "";
            mskCep.Text = "";
            mskTelefone.Text = "";
            txtComissao.Text = "0,00";
            txtReferencia.Text = "";
            mskTelefoneReferencia.Text = "";
            rtbObservacao.Text = "";
            //Popula comboBox de estados
            cmbUf.DataSource = UfController.ListarTodasUFs();
            //Popula grid com vendedores já cadastrados
            pPopulaVendedores();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            pessoa objPessoa = null;
            int codigo = 0;
            //Valida se foi informado cpf
            if (mskCpf.Text == string.Empty || mskCpf.Text == "   ,   ,   -")
            {
                MessageBox.Show("Informe o CPF do(a) vendedor(a).");
                mskCpf.Focus();
                return;
            }
            //Valida se foi informado o nome do venddor
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do(a) vendedor(a).");
                txtNome.Focus();
                return;
            }
            //Valida se foi informado o telefone do venddor
            if (mskTelefone.Text == string.Empty || mskTelefone.Text == "(  )     -")
            {
                MessageBox.Show("Informe o telefone do(a) vendedor(a).");
                mskTelefone.Focus();
                return;
            }
            //Valida se foi informada a comissão do venddor
            if (txtComissao.Text == string.Empty || txtComissao.Text == "0,00")
            {
                MessageBox.Show("Informe a comissão do(a) vendedor(a).");
                txtComissao.Focus();
                return;
            }
            //Valida se foi informada a referencia
            if (txtReferencia.Text == string.Empty)
            {
                MessageBox.Show("Informe a referência do(a) vendedor(a).");
                txtReferencia.Focus();
                return;
            }
            //Valida se foi informada o telefone da referencia
            if (mskTelefoneReferencia.Text == string.Empty || mskTelefoneReferencia.Text == "(  )      -")
            {
                MessageBox.Show("Informe o telefone da referência do(a) vendedor(a).");
                mskTelefoneReferencia.Focus();
                return;
            }
            if (txtCodigo.Text != string.Empty)
            {
                //passa o codigo para uma variavel
                codigo = int.Parse(txtCodigo.Text);
                //Consulta grupo pelo id
                objPessoa = PessoaController.BuscaPessoaPorID(codigo);
            }
            //Se grupo não existir ele grava
            if (objPessoa == null)
            {
                //Mota objeto de grupo para salvar
                objPessoa = pMontaObjPessoa();
                //Salva grupo
                PessoaController.SalvarPessoa(objPessoa);
                //mostra mensagem para o usuario
                MessageBox.Show("Vendedor(a) gravado(a) com sucesso.");
            }
            else
            {
                //Mota objeto de grupo para salvar
                objPessoa = pMontaObjPessoa();
                //Salva grupo
                PessoaController.AlterarPessoa(codigo, objPessoa);
                //mostra mensagem para o usuario
                MessageBox.Show("Vendedor(a) alterado(a) com sucesso.");
            }
            //Limpa os campos
            btnClear_Click(sender, e);
            //Coloca o foco no cpf
            mskCpf.Focus();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Valida se foi informado um codigo
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um vendedor(a).");
                txtCodigo.Focus();
                return;
            }
            int codigo = Convert.ToInt32(txtCodigo.Text);
            //Consulta grupo por ID
            pessoa objPessoa = PessoaController.BuscaPessoaPorID(codigo);
            //Valida se vendedor existe
            if (objPessoa == null)
            {
                MessageBox.Show("O vendedor(a) não está cadastrado.");
                return;
            }
            //Exclui o vendedor
            PessoaController.ExcluirPessoa(Convert.ToInt32(txtCodigo.Text.ToString()));
            MessageBox.Show("Vendedor(a) excluído(a) com sucesso.");
            //Repopula grid
            btnClear_Click(sender, e);
        }

        //DoubleClick
        private void dgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Verifica se a linha selecionada e valida
                if (e.RowIndex < 0)
                {
                    return;
                }
                //Preenche os campos
                txtCodigo.Text = dgvVendedores.Rows[e.RowIndex].Cells[ColunaId.Index].Value.ToString();
                //Chama o leave do codigo
                txtCodigo_Leave(txtCodigo, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "Funções e Procedimentos"
        private void pPopulaComboCidade()
        {
            //Busca as cidades no banco de dados de acordo com a UF
            cmbCidade.DataSource = CidadeController.PopulaComboCidadePorUF(int.Parse(cmbUf.SelectedValue.ToString()));
        }
        private pessoa pMontaObjPessoa()
        {
            pessoa objPessoa = new pessoa();
            objPessoa.cpf = mskCpf.Text.Replace(",", "").Replace("-", "");
            objPessoa.nascimento = dtpNascimento.Value;
            objPessoa.nome = txtNome.Text;
            objPessoa.endereco = txtEndereco.Text;
            objPessoa.complemento = txtComplemento.Text;
            objPessoa.bairro = txtBairro.Text;
            objPessoa.numEndereco = txtNr.Text;
            objPessoa.cep = mskCep.Text.Replace(",", "").Replace("-", "");
            objPessoa.uf = int.Parse(cmbUf.SelectedValue.ToString());
            objPessoa.codigoCidade = cmbCidade.SelectedValue.ToString();
            objPessoa.telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            objPessoa.comissao = decimal.Parse(txtComissao.Text);
            objPessoa.nomeReferencia = txtReferencia.Text;
            objPessoa.telefoneReferencia = mskTelefoneReferencia.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            objPessoa.observacao = rtbObservacao.Text;
            return objPessoa;
        }
        private void pPopulaVendedores()
        {
            //Consulta todos os vendedores
            List<pessoa> objPessoa = PessoaController.ListarTodasPessoas();
            DataGridViewRow dgvr;
            dgvVendedores.Rows.Clear();
            //Percorre o objeto para preencher a grid
            foreach (var item in objPessoa)
            {
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgvVendedores);
                dgvr.Cells[ColunaId.Index].Value = item.id;
                dgvr.Cells[ColunaCpf.Index].Value = item.cpf;
                dgvr.Cells[ColunaNome.Index].Value = item.nome;
                dgvr.Cells[ColunaTelefone.Index].Value = item.telefone;
                dgvVendedores.Rows.Add(dgvr);

            }
        }
        #endregion
    }
}
