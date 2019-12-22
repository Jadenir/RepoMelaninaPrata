using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelaninaModel.Grupos;

namespace MelaninaModel.Produtos
{
    public class Produto
    {
        private int id;
        private string descricao;
        private decimal valor;
        private decimal custo;
        private string referencia;
        private Grupo grupo;

        public Produto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public Grupo Grupo { get => grupo; set => grupo = value; }

    }
}
