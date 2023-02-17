using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteUpd8.Api.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNacimento { get; set; }
        public Sexo Sexo { get; set; }
        public string Endereco { get; set; }
        public Estado Estado { get; set; }

        public Cliente(int id, string cpf , string nome, DateTime dataNacimento, Sexo sexo, string endereco, Estado estado)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            DataNacimento = dataNacimento;
            Sexo = sexo;
            Endereco = endereco;
            Estado = estado;
        }

    }

}
