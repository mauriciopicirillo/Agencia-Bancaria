using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente (string nome, string cpf, string rg, Endereco endereço)
        {
            
            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Endereço = endereço ?? throw new Exception("Endereço deve ser informado.");
        }
               

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereço { get; private set; }

    }
}
