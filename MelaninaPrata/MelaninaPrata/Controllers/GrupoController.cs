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
            grupos grupo = ContextoSingleton.Instancia.grupos.Find(id);

            ContextoSingleton.Instancia.Entry(grupo).State = EntityState.Deleted;
            ContextoSingleton.Instancia.SaveChanges();
        }
        //Lista por ID
        public static List<grupos> ListarGrupoPorID(int id)
        {
            grupos grupo = ContextoSingleton.Instancia.grupos.Find(id);
            return ContextoSingleton.Instancia.grupos.ToList();
        }
        //Lista todos os grupos
        public static List<grupos> ListarTodosGrupos()
        {
            return ContextoSingleton.Instancia.grupos.ToList();
        }
    }
}
