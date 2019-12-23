﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelaninaModels.DAL;


namespace MelaninaControllers
{
    public class ContextoSingleton
    {
        private static MeuContexto instancia;
        public static MeuContexto Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new MeuContexto();
                return instancia;
            }
        }

        private ContextoSingleton()
        {

        }
    }
}
