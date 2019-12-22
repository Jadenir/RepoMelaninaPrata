using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MelaninaModel.Grupos
{
    public class GrupoDAO
    {
        public void pGrava(Grupo grupo)
        {
            string sql = "insert into grupos"
                + "(id, descricao)"
                + " values (default,"
                + "'" + grupo.Descricao + "')";

            MelaninaModel.Conexao.Conexao.pManipulaPostgreSQL(sql);
        }
        public void pAltera(Grupo grupo)
        {
            string sql = "update grupos"
                + " set descricao = '" + grupo.Descricao + "'"
                + " where id = " + grupo.Id;

            MelaninaModel.Conexao.Conexao.pManipulaPostgreSQL(sql);
        }
        public void pExclui(Grupo grupo)
        {
            string sql = "delete from grupos"
                + " where id = " + grupo.Id;

            MelaninaModel.Conexao.Conexao.pManipulaPostgreSQL(sql);
        }
        public List<Grupo> fConsultaTodos()
        {
            //Variaveis
            DataTable dt;
            Grupo objGrupo;
            List<Grupo> objGrupos = new List<Grupo>();

            string sql = "select * from grupos order by id";

            dt = MelaninaModel.Conexao.Conexao.fConsultaPostgreSQL(sql).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objGrupo = new Grupo();
                objGrupo.Id = dt.Rows[i].Field<int>("Id");
                objGrupo.Descricao = dt.Rows[i].Field<string>("descricao");
                objGrupos.Add(objGrupo);
            }
            return objGrupos;
        }
        public Grupo fConsultaGrupo(int codigo)
        {
            //Variaveis
            DataTable dt;
            Grupo objGrupo = new Grupo();

            string sql = "select * from grupos";
            sql += " where id = " + codigo.ToString();

            dt = MelaninaModel.Conexao.Conexao.fConsultaPostgreSQL(sql).Tables[0];

            if (dt.Rows.Count != 0)
            {
                objGrupo.Id = dt.Rows[0].Field<int>("Id");
                objGrupo.Descricao = dt.Rows[0].Field<string>("descricao");
                return objGrupo;
            }

            return null;
        }
        public int fProximoCodigo()
        {
            //Variaveis
            DataTable dt;

            string sql = "select coalesce(max(\"Id\"),0,0) + 1 proximo from grupos";

            dt = MelaninaModel.Conexao.Conexao.fConsultaPostgreSQL(sql).Tables[0];

            if (dt.Rows.Count != 0)
            {
                return int.Parse(dt.Rows[0].Field<object>("proximo").ToString());
            }

            return 1;
        }
        public static void pPopulaGrupo(ref ComboBox comboBox)
        {
            //Variaveis
            DataTable dt;
            
            string sql = "select * from grupos order by id";

            dt = MelaninaModel.Conexao.Conexao.fConsultaPostgreSQL(sql).Tables[0];
            
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id";
            comboBox.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
