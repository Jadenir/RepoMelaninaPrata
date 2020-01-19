using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MelaninaPrata.Models;

namespace MelaninaPrata.Controllers
{
    public class CidadeController
    {
        //Lista por ID
        public static cidade BuscaCidadePorID(int id)
        {
            cidade objCidade = ContextoSingleton.Instancia.cidades.Find(id);
            return objCidade;
        }
        //Lista ComboBox por UF
        public static List<cidade> PopulaComboCidadePorUF(int uf)
        {
            //DataTable dados = new DataTable();
            //ComboBox objComboBox = new ComboBox();
            List<cidade> objCidade = ContextoSingleton.Instancia.cidades.Where<cidade>(c => c.uf == uf).ToList();

            //dados.Columns.Add("COD");
            //dados.Columns.Add("DESC");

            //for (int i =0; i < objCidade.Count; i++)
            //{
            //    dados.Rows.Add(objCidade[i].id,
            //                   objCidade[i].nome);
            //}
            //return dados;
            return objCidade;
        }
        //Lista todos as cidades
        public static List<cidade> ListarTodasCidades()
        {
            return ContextoSingleton.Instancia.cidades.ToList();
        }


    }
}
