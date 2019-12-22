using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelaninaModel.Produtos
{
    public class ProdutoDAO
    {
        public void pGrava(Produto produto)
        {
            string sql = "insert into produtos"
                + "(id, descricao, valor, custo, referencia, grupo)"
                + " values ("
                + "default,'"
                + produto.Descricao + "',"
                + produto.Valor + ","
                + produto.Custo + ",'"
                + produto.Referencia + "',"
                + produto.Grupo.Id + ")";

            MelaninaModel.Conexao.Conexao.pManipulaPostgreSQL(sql);
        }
        public void pAltera(Produto produto)
        {
            string sql = "update produtos"
                 + " set grupo = " + produto.Grupo.Id
                 + ", descricao = '" + produto.Descricao + "'"
                 + ", valor = '" + produto.Valor 
                 + ", custo = '" + produto.Custo 
                 + ", referencia = '" + produto.Referencia + "'"
                 + " where"
                 + " and id = " + produto.Id;

            MelaninaModel.Conexao.Conexao.pManipulaPostgreSQL(sql);

        }
        
    }
}
