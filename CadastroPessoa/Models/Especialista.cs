using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Models.Enums;

namespace CadastroPessoa.Models
{
    public class Especialista
    {
        public string NomeDoutor{ get; set; }
        public Especialidade especialidade { get; set; }
        public Especialista()
        {

        }

        public Especialista(string nomeDoutor, Especialidade especialidade)
        {
            NomeDoutor = nomeDoutor;
            this.especialidade = especialidade;
        }
    }
}
