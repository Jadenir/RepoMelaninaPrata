using MelaninaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelaninaControllers
{
    public class GrupoController
    {
        public static void SalvarGrupo(Grupo grupo)
        {
            ContextoSingleton.Instancia.Grupos.Add(grupo);
            ContextoSingleton.Instancia.SaveChanges();
        }
        public static void AlterarGrupo(int id, Grupo novoGrupo)
        {

            Grupo grupo = ContextoSingleton.Instancia.Grupos.Find(id);

            if (grupo != null)
            {
                grupo.Descricao = novoGrupo.Descricao;
            }

            ContextoSingleton.Instancia.Entry(grupo).State =
                System.Data.Entity.EntityState.Modified;
            ContextoSingleton.Instancia.SaveChanges();
        }
        public static void ExcluirGrupo(int id)
        {

            Grupo grupo = ContextoSingleton.Instancia.Grupos.Find(id);

            ContextoSingleton.Instancia.Entry(grupo).State =
                System.Data.Entity.EntityState.Deleted;
            ContextoSingleton.Instancia.SaveChanges();

        }
        public static List<Grupo> ListarTodosGrupos()
        {
            return ContextoSingleton.Instancia.Grupos.ToList();
        }
    }
}
