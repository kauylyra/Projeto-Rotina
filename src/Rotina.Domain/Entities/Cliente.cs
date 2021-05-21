using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotina.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }
        [Key]
        public int ID_Cliente { get; set; }
        public string Nome { get;  set; }
        public string Cidade { get;  set; }
        public string Bairro { get;  set; }
        public bool Ativo { get;  set; }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void SetBairro   (string bairro)
        {
            Bairro = bairro;
        }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
