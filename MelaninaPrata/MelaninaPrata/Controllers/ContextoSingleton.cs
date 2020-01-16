using MelaninaPrata.Models;

namespace MelaninaPrata.Controllers
{
    public class ContextoSingleton
    {
        private static DBMelaninaEntities instancia;
        public static DBMelaninaEntities Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new DBMelaninaEntities();
                return instancia;
            }
        }

        private ContextoSingleton()
        {

        }
    }
}
