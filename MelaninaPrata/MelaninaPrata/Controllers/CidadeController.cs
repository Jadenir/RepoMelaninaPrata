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
        //Lista por Codigo do IBGE
        public static List<cidade> BuscaCidadePorCodIBGE(int CodIBGE)
        {
            //Consulta cidade por uf
            List<cidade> objCidade = ContextoSingleton.Instancia.cidades.Where<cidade>(c => c.codigoIBGE == CodIBGE).ToList();
            //return dados;
            return objCidade;
        }
        //Lista ComboBox por UF
        public static List<cidade> PopulaComboCidadePorUF(int uf)
        {
            //Consulta cidade por uf
            List<cidade> objCidade = ContextoSingleton.Instancia.cidades.Where<cidade>(c => c.uf == uf).ToList();
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
