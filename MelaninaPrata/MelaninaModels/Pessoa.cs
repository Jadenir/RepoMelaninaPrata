using System;
using System.Collections.Generic;
using System.Text;

namespace MelaninaModels
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public decimal Comissao { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string NumEndereco { get; set; }
        public string Cep { get; set; }
        public int Uf { get; set; }
        public string CidadeId { get; set; }
        public virtual Cidade _Cidade { get; set; }
    }
}
