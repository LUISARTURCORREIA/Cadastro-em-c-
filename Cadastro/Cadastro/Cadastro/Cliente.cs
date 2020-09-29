using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Nome;
        }

    }
}
