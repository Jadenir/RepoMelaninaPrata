using System;
using System.Collections.Generic;
using System.Linq;
using MelaninaPrata.Models;
using System.Data.Entity;

namespace MelaninaPrata.Controllers
{
    public class ProdutoController
    {
        //Salva o grupo
        public static void SalvarProduto(produto produto)
        {
            ContextoSingleton.Instancia.produtos.Add(produto);
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Altera o grupo
        public static void AlterarProduto(int id, produto novoProduto)
        {
            produto produto = ContextoSingleton.Instancia.produtos.Find(id);

            if (produto != null)
            {
                novoProduto.id = produto.id;
                produto = novoProduto;
            }

            ContextoSingleton.Instancia.Entry(produto).State = EntityState.Modified;
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Exclui o grupo
        public static void ExcluirProduto(int id)
        {
            //Consulta e retorna grupo
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
        //Lista todos os grupos
        public static List<produto> ListarTodosProdutos()
        {
            return ContextoSingleton.Instancia.produtos.ToList();
        }
    }
}
