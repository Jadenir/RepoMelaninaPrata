using System.Data;
using System.Windows.Forms;

namespace MelaninaModel.Municipios
{
    class MunicipioDAO
    {
        public static void pPopulaMunicipio(ref ComboBox comboBox, int uf)
        {
            //Variaveis
            DataTable dt;
            //DataRow dr;

            string sql = "select * from municipios where uf = " + uf +
                         " order by nome";

            dt = MelaninaModel.Conexao.Conexao.fConsultaPostgreSQL(sql).Tables[0];

            //if (incluirTodas)
            //{
            //    dr = dt.NewRow();
            //    dr.SetField("codigo_marc", "0");
            //    dr.SetField("nome_marc", "TODAS");
            //    dt.Rows.InsertAt(dr, 0);
            //}

            comboBox.DisplayMember = "nome";
            comboBox.ValueMember = "codigo";
            comboBox.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
