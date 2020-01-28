using System;
using System.Collections.Generic;
using System.Linq;
using MelaninaPrata.Models;
using System.Data.Entity;

namespace MelaninaPrata.Controllers
{
    public class ProdutoController
    {
        //Salva o produto
        public static void SalvarProduto(produto produto)
        {
            ContextoSingleton.Instancia.produtos.Add(produto);
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Altera o produto
        public static void AlterarProduto(int id, produto novoProduto)
        {
            produto objProduto = ContextoSingleton.Instancia.produtos.Find(id);

            if (objProduto != null)
            {                
                objProduto.referencia = novoProduto.referencia;
                objProduto.descricao = novoProduto.descricao;
                objProduto.grupoId = novoProduto.grupoId;
                objProduto.valor = novoProduto.valor;
                objProduto.custo = novoProduto.custo;
            }

            ContextoSingleton.Instancia.Entry(objProduto).State = EntityState.Modified;
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Exclui o produto
        public static void ExcluirProduto(int id)
        {
            //Consulta e retorna produto
            produto produto = ContextoSingleton.Instancia.produtos.Find(id);
            //Deleta registro da tabela
            ContextoSingleton.Instancia.Entry(produto).State = EntityState.Deleted;
            //Salva alteração na tabela
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Lista por ID
        public static produto BuscaProdutoPorID(int id)
        {
            produto produto = ContextoSingleton.Instancia.produtos.Find(id);
            return produto;
        }
        //Lista todos os produto
        public static List<produto> ListarTodosProdutos()
        {
            return ContextoSingleton.Instancia.produtos.ToList();
        }
    }
}
