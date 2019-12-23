using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Referencia { get; set; }
        public decimal Valor { get; set; }
        public decimal Custo { get; set; }
        public int GrupoId { get; set; }
        public virtual Grupo _Grupo { get; set; }
    }
}
