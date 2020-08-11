using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasci { get; set; }
        public int NumeCel { get; set; }
        public List<Consulta> consultas { get; set; } = new List<Consulta>();
        public Cliente()
        {

        }
        public Cliente(int id, string nome, DateTime dataNasci, int numeCel)
        {
            Id = id;
            Nome = nome;
            DataNasci = dataNasci;
            NumeCel = numeCel;
        }
    }
}
