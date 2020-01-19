using System.Collections.Generic;
using System.Linq;
using MelaninaPrata.Models;

namespace MelaninaPrata.Controllers
{
    public class UfController
    {
        public static List<estado> ListarTodasUFs()
        {
            return ContextoSingleton.Instancia.estados.ToList();
        }
    }
}
