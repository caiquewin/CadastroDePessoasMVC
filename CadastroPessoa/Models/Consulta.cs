using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Models.Enums;

namespace CadastroPessoa.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public StatusPagamento statusPagamento { get; set; }
        public string Comentario { get; set; }
        public Especialidade especialidades { get; set; }
        public Consulta()
        {

        }

        public Consulta(int id, DateTime data, StatusPagamento statusPagamento, string comentario, Especialidade especialidades)
        {
            Id = id;
            Data = data;
            this.statusPagamento = statusPagamento;
            Comentario = comentario;
            this.especialidades = especialidades;
        }
    }

}
