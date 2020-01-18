using System;
using System.Collections.Generic;
using System.Linq;
using MelaninaPrata.Models;
using System.Data.Entity;

namespace MelaninaPrata.Controllers
{
    public class GrupoController
    {
        //Salva o grupo
        public static void SalvarGrupo(grupos grupo)
        {
            ContextoSingleton.Instancia.grupos.Add(grupo);
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Altera o grupo
        public static void AlterarGrupo(int id, grupos novoGrupo)
        {
            grupos grupo = ContextoSingleton.Instancia.grupos.Find(id);

            if (grupo != null)
            {
                grupo.descricao = novoGrupo.descricao;
            }

            ContextoSingleton.Instancia.Entry(grupo).State = EntityState.Modified;
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Exclui o grupo
        public static void ExcluirGrupo(int id)
        {
            //Consulta e retorna grupo
            grupos grupo = ContextoSingleton.Instancia.grupos.Find(id);
            //Deleta registro da tabela
            ContextoSingleton.Instancia.Entry(grupo).State = EntityState.Deleted;
            //Salva alteração na tabela
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Lista por ID
        public static grupos BuscaGrupoPorID(int id)
        {
            grupos grupo = ContextoSingleton.Instancia.grupos.Find(id);
            return grupo;//ContextoSingleton.Instancia.grupos.ToList();
        }
        //Lista todos os grupos
        public static List<grupos> ListarTodosGrupos()
        {
            return ContextoSingleton.Instancia.grupos.ToList();
        }
    }
}
