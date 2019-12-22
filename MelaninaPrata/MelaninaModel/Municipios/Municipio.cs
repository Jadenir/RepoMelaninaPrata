using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelaninaModel.Municipios
{
    public class Municipio
    {
        int id;
        int codigo;
        string nome;
        int uf;

        public Municipio()
        {
        }

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Uf { get => uf; set => uf = value; }
    }
}
