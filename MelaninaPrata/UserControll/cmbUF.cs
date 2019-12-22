using System;
using System.Data;
using System.Windows.Forms;

namespace UserControll
{
    public partial class cmbUF : UserControl
    {
        //Variaveis
        string _valueMember;
        string _displayMember;

        public cmbUF()
        {
            InitializeComponent();
            _valueMember = "codigo";
        }
        public enum definicao
        {
            codigo,
            sigla,
            extenso
        };
        private void cmbUF_Load(object sender, EventArgs e)
        {
            populaUF();
        }
        private void populaUF()
        {

            DataTable dados = new DataTable();
            DataRow linha;

            dados.Columns.Add("codigo");
            dados.Columns.Add("sigla");
            dados.Columns.Add("extenso");

            linha = dados.NewRow();
            linha.SetField("codigo", "11");
            linha.SetField("sigla", "RO");
            linha.SetField("extenso", "Rondônia");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "12");
            linha.SetField("sigla", "AC");
            linha.SetField("extenso", "Acre");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "13");
            linha.SetField("sigla", "AM");
            linha.SetField("extenso", "Amazonas");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "14");
            linha.SetField("sigla", "RR");
            linha.SetField("extenso", "Roraima");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "15");
            linha.SetField("sigla", "PA");
            linha.SetField("extenso", "Pará");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "16");
            linha.SetField("sigla", "AP");
            linha.SetField("extenso", "Amapá");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "17");
            linha.SetField("sigla", "TO");
            linha.SetField("extenso", "Tocantins");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "21");
            linha.SetField("sigla", "MA");
            linha.SetField("extenso", "Maranhão");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "22");
            linha.SetField("sigla", "PI");
            linha.SetField("extenso", "Piauí");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "23");
            linha.SetField("sigla", "CE");
            linha.SetField("extenso", "Ceará");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "24");
            linha.SetField("sigla", "RN");
            linha.SetField("extenso", "Rio Grande do Norte");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "25");
            linha.SetField("sigla", "PB");
            linha.SetField("extenso", "Paraíba");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "26");
            linha.SetField("sigla", "PB");
            linha.SetField("extenso", "Pernambuco");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "27");
            linha.SetField("sigla", "AL");
            linha.SetField("extenso", "Alagoas");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "28");
            linha.SetField("sigla", "SE");
            linha.SetField("extenso", "Sergipe");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "29");
            linha.SetField("sigla", "BA");
            linha.SetField("extenso", "Bahia");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "31");
            linha.SetField("sigla", "MG");
            linha.SetField("extenso", "Minas Gerais");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "32");
            linha.SetField("sigla", "ES");
            linha.SetField("extenso", "Espírito Santo");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "33");
            linha.SetField("sigla", "RJ");
            linha.SetField("extenso", "Rio de Janeiro");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "35");
            linha.SetField("sigla", "SP");
            linha.SetField("extenso", "São Paulo");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "41");
            linha.SetField("sigla", "PR");
            linha.SetField("extenso", "Paraná");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "42");
            linha.SetField("sigla", "SC");
            linha.SetField("extenso", "Santa Catarina");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "43");
            linha.SetField("sigla", "RS");
            linha.SetField("extenso", "Rio Grande do Sul");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "50");
            linha.SetField("sigla", "MS");
            linha.SetField("extenso", "Mato Grosso do Sul");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "51");
            linha.SetField("sigla", "MT");
            linha.SetField("extenso", "Mato Grosso");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "52");
            linha.SetField("sigla", "GO");
            linha.SetField("extenso", "Goiás");
            dados.Rows.Add(linha);

            linha = dados.NewRow();
            linha.SetField("codigo", "53");
            linha.SetField("sigla", "DF");
            linha.SetField("extenso", "Distrito Federal");
            dados.Rows.Add(linha);

            comboBox1.ValueMember = _valueMember;
            comboBox1.DisplayMember = _displayMember;
            comboBox1.DataSource = dados;

        }
        public definicao displayMember
        {

            get
            {
                if (_displayMember == "codigo")
                {
                    return definicao.codigo;
                }
                if (_displayMember == "sigla")
                {
                    return definicao.sigla;
                }
                if (_displayMember == "extenso")
                {
                    return definicao.extenso;
                }
                return definicao.codigo;
            }

            set
            {
                if (definicao.codigo == value)
                {
                    _displayMember = "codigo";
                }
                if (definicao.sigla == value)
                {
                    _displayMember = "sigla";
                }
                if (definicao.extenso == value)
                {
                    _displayMember = "extenso";
                }
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
