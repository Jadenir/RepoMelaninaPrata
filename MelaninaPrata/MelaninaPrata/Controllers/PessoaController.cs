using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MelaninaPrata.Models;

namespace MelaninaPrata.Controllers
{
    public class PessoaController
    {
        //Salva o Pessoa
        public static void SalvarPessoa(pessoa objPessoa)
        {
            ContextoSingleton.Instancia.pessoas.Add(objPessoa);
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Altera o pessoa
        public static void AlterarPessoa(int id, pessoa novaPessoa)
        {
            pessoa objPessoa = ContextoSingleton.Instancia.pessoas.Find(id);

            if (objPessoa != null)
            {
                objPessoa.cpf = novaPessoa.cpf;
                objPessoa.nascimento = novaPessoa.nascimento;
                objPessoa.nome = novaPessoa.nome;
                objPessoa.endereco = novaPessoa.endereco;
                objPessoa.complemento = novaPessoa.complemento;
                objPessoa.numEndereco = novaPessoa.numEndereco;
                objPessoa.cep = novaPessoa.cep;
                objPessoa.uf = novaPessoa.uf;
                objPessoa.codigoCidade = novaPessoa.codigoCidade;
                objPessoa.telefone = novaPessoa.telefone;
                objPessoa.comissao = novaPessoa.comissao;
            }

            ContextoSingleton.Instancia.Entry(objPessoa).State = EntityState.Modified;
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Exclui o pessoa
        public static void ExcluirPessoa(int id)
        {
            //Consulta e retorna pessoa
            pessoa objPessoa = ContextoSingleton.Instancia.pessoas.Find(id);
            //Deleta registro da tabela
            ContextoSingleton.Instancia.Entry(objPessoa).State = EntityState.Deleted;
            //Salva alteração na tabela
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Lista por ID
        public static pessoa BuscaPessoaPorID(int id)
        {
            pessoa objPessoa = ContextoSingleton.Instancia.pessoas.Find(id);
            return objPessoa;
        }
        //Lista todos as pessoas
        public static List<pessoa> ListarTodasPessoas()
        {
            return ContextoSingleton.Instancia.pessoas.ToList();
        }
    }
}
